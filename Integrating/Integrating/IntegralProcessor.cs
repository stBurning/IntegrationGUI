using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace Integrating {
    class IntegralProcessor {

        private int donePercent = 0;
        public delegate void Progress(int value);
        public delegate void ToDraw(double x, double y, int part);
        public delegate void Finish(double result, long time);
        public event Progress EventProgress;
        public event ToDraw EventDraw;
        public event Finish EventFinish;

        System.Diagnostics.Stopwatch sw;
        int parts = Environment.ProcessorCount;//Кол-во логических ядер / число потоков 
        private readonly Func<double, double> function; //Интегрируемая функция
        
        public IntegralProcessor(Func<double, double> f) {
            Console.WriteLine("Для вычислений выделено {0} логических процессоров.", parts);
            this.function = f;  
            sw = new Stopwatch();
        }


        public double RectangularI(double left, double right, int n) {
            sw.Start();  //Замеряем время
            donePercent = 0;
            Random random = new Random();
            //Rectangular Integration
            double dt = (right - left) / n;
            double result = 0;
            int partsSize = (int)n / parts;
            int reminder = n - partsSize * parts; 
            object block = new object();
            

            void calculating(int part) {
                int step = 10;
                int start = part * partsSize + ((part < reminder) ? part : reminder);
                int finish = (part + 1) * partsSize + ((part + 1 < reminder) ? part : (reminder - 1));
                //Console.WriteLine("Для {0} потока начальный индекс - {1}, конечный - {2}", part, start, finish);
                int percentsDelta = (int)(Math.Round((double)(100/n)));
                //Console.WriteLine("{0}: Start - {1}, Finish - {2}, PercentDt - {3}",part, start, finish, percentsDelta);
                double x = left + (start + 0.5)*dt;
                double part_result = 0;
                for (int i = start; i <= finish; i++) { 
                    part_result += function(x) * dt;
                    EventDraw?.Invoke(x, function(x), part);
                    x += dt;
                    donePercent+=percentsDelta;
                    if(donePercent > step) {
                        EventProgress?.Invoke(donePercent);
                        step += 10;
                    }
                    
                    
                }
                Monitor.Enter(block);
                    result += part_result;
                Monitor.Exit(block);

            }

            Parallel.For(0, parts, calculating);
            sw.Stop();
            EventFinish?.Invoke(result, sw.ElapsedMilliseconds);
            return result;
        }

        public double Monte_CarloI(double left, double right, int throwsMultiplier, double sup , double inf ,int strats_count) {
            sw.Start();  //Замеряем время
            double dt = (right - left)/strats_count;
            Console.WriteLine("dt: {0}", dt);
            
            int throws = (int)(Math.Round((sup - inf) / dt)) * strats_count * throwsMultiplier;
            //int throws = Math.Floor((sup - inf) / dt) * strats_count) * throwsMultiplier;
            Console.WriteLine("Всего будет сделано {0} бросков", throws);

            double result = 0;
            double partLength = (right - left) / parts;
            int partsSize = strats_count / parts;
            int reminder = strats_count - partsSize * parts;

            object block = new object();

            void calculating(int part) {
                int percentsDelta = throws / 100;
                Random randomX = new Random(DateTime.Now.Millisecond*(part+1));
                Random randomY = new Random(DateTime.Now.Millisecond * (part + 2));
                Console.WriteLine("[Thread №{0}] Начаты вычисления в потоке...", part);
                int count = 0;//Кол-во точек под графиком
                int start = part * partsSize + ((part < reminder) ? part : reminder);
                int finish = (part + 1) * partsSize + ((part + 1 < reminder) ? part : (reminder - 1));
                Console.WriteLine("[Thread №{0}] Задана область интегрирования: [{1}; {2}]x[{3}, {4}]", part, start*dt, finish*dt + dt, inf, sup);

                double x_id = left + start * dt;
                double y_id = inf;
                for (int i = 0; i < throws/parts; i++) {
                    //Console.WriteLine("[Thread №{0}] Страта - [{1}; {2}]x[{3}, {4}]", part, x_id, x_id + dt, y_id, y_id + dt);
                    // Генерируем случайную точку в диапазоне (x_id + dx, y_id + dy)
                    double x = randomX.NextDouble() * dt + x_id;
                    double y = randomY.NextDouble() * dt + y_id;
                    if (i % 117 == 0) EventDraw?.Invoke(x, y, part);
                    //Проверяем вхождение точки в область под графиком
                    if (function(x) >= 0) {
                        if (y <= function(x) && y >= 0) count++;
                    } else {
                        if (y >= function(x) && y < 0) count--;}

                    //Console.WriteLine("[{2}] ({1}) Y[{5}, {6}]", x, y, part, x_id, x_id + dx, y_id, y_id + dy);
                    
                    //Изменение области генерации
                    x_id += dt;//Сдвигаемся по Х
                    if (x_id > left + finish * dt) {//При выходе за границу по Х
                        y_id += dt; //Поднимаемся на уровень выше
                        x_id = left + start * dt; //Возвращаемся на начальное значения Х
                        if (y_id >= sup) y_id = inf; //При выходе за границу по Y и по Х начинаем сначала
                    }

                    if ((i) % (percentsDelta) == 0) {
                        donePercent++;
                        EventProgress?.Invoke(donePercent);
                    }
                }
                Console.WriteLine("[Thread №{0}]: Кол-во попаданий = {1}\n" +
                                  "    \t     Всего бросков: {2}", part, count, throws / parts);
                Monitor.Enter(block);
                result += count;
                Monitor.Exit(block);
            }

            Parallel.For(0, parts, calculating);
            result = (result / throws) * (right - left) * (sup - inf);
            sw.Stop();
            EventFinish?.Invoke(result, sw.ElapsedMilliseconds);
            return result;
        }


        public double SimpsonI(double left, double right, int n) {
            sw.Start();  //Замеряем время
            object block = new object();
            double result = 0;
            void calculate(int part) {
                int percents_step = 10;
                double width = (right - left) / (n);
                double local_left = left + (right - left) * part / parts;
                Console.WriteLine("{0} local_left = {1}", part, local_left);
                double local_result = 0;
                int steps = n / parts;
                int percentsDelta = (int)(Math.Round((double)(100 / n)));
                for (int step = 0; step < steps; step++) {
                    double x1 = local_left + step * width;
                    double x2 = local_left + (step + 1) * width;
                    local_result += (x2 - x1) / 6.0 * (function(x1) + 4.0 * function(0.5 * (x1 + x2)) + function(x2));
                    EventDraw?.Invoke(x1, x2, part);
                    donePercent += percentsDelta;
                    if (donePercent > percents_step) {
                        EventProgress?.Invoke(donePercent);
                        percents_step += 10;
                    }
                }
                Monitor.Enter(block);
                result += local_result;
                Monitor.Exit(block);
            }

            Parallel.For(0, parts, calculate);
            sw.Stop();
            EventFinish?.Invoke(result, sw.ElapsedMilliseconds);
            return result;
        }
    }

}
