using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Integrating {
    public partial class Form1 : Form {


        double F( double x) {
            return x * x * x - 5 * x * x;
        }
        public Form1() {
            InitializeComponent();
            drawGraphic(Decimal.ToDouble(LowerBoundRectVal.Value), Decimal.ToDouble(UpperBoundRectVal.Value), 0);

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            
            //Settings seletion
            switch (comboBox1.Text) {
                case "Rectangular": {
                        label14.Text = "";
                        MonteCarloGBox.Visible = false;
                        RectangularGBox.Visible = true;
                        break;
                    }
                case "Monte-Carlo(with stratification)": {
                        label14.Text = "";
                        RectangularGBox.Visible = false;
                        MonteCarloGBox.Visible = true;
                        break;
                    }
                case "Simpson's method": {
                        label14.Text = "";
                        MonteCarloGBox.Visible = false;
                        RectangularGBox.Visible = true;
                        break;
                    }
            }
        }
        private void drawParabola(double left, double right, int part) {
            double dx = (right - left) /( Decimal.ToInt32(numberOfIterRect.Value) * 4);
            double middle = (right - left) / 2;
            double interpol(double _x) {
                return F(left) * (_x - middle) * (_x - right) / ((left - middle) * (left - right))
                    + F(middle) * (_x - left) * (_x - right) / ((middle - left) * (middle - right))
                    + F(right) * (_x - left) * (_x - middle) / ((right - left) * (right - middle));
            }
            if (!chart1.InvokeRequired) {
                double x = left-dx*50;

                while (x <= right+dx*50) {

                    chart1.Series["Thread №" + part.ToString()].Points.AddXY(x, interpol(x));
                    x = x + dx;
                }
            } else {
                object[] pars = { left, right, part };
                Invoke(new IntegralProcessor.ToDraw(drawParabola), pars);
            }

        }

        private void drawGraphic(double left, double right, int part) {

            chart1.Series[0].Points.Clear();
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            double x = left;
            
            while(x <= right) {
                double y = F(x);
                chart1.Series[0].Points.AddXY(x, y);
                x = x + 0.1;
            }
        }

        private void OnProgress(int value) {
            if (!progressBar1.InvokeRequired) {
                if (value <= 100 ) progressBar1.Value = value;
            } else
                Invoke(new IntegralProcessor.Progress(OnProgress), value);
        }

        private void OnProgressValue(int value) {
            if (!textBoxResult.InvokeRequired) {
                if (value <= 100) textBoxResult.Text = "Выполнено: " + value.ToString() + "%";
            }else
                Invoke(new IntegralProcessor.Progress(OnProgressValue), value);
        }

        private void OnFinish(double resVal, long time) {
            if (!textBoxResult.InvokeRequired && !progressBar1.InvokeRequired) {
                textBoxResult.Text = resVal.ToString();
            } else {
                object[] pars = { resVal, time};
                Invoke(new IntegralProcessor.Finish(OnFinish), pars);

            }
        }
        private void OnFinishTime(double resVal, long time) {
            if (!label14.InvokeRequired) {
                label14.Text = "Time spent to calculate: " + (time/1000.0).ToString() + " c";
            } else {
                object[] pars = { resVal, time };
                Invoke(new IntegralProcessor.Finish(OnFinishTime), pars);

            }
        }
        private void DrawHist(double x, double y, int part) {
            if (!chart1.InvokeRequired) {
                chart1.Series.FindByName("Hists").Points.AddXY(x, F(x));
                
            } else {
                object[] pars = { x, y , part};
                Invoke(new IntegralProcessor.ToDraw(DrawHist), pars);
            }
        }
        private void DrawPoint(double x, double y, int part) {

            if (!chart1.InvokeRequired) {
                chart1.Series.FindByName("Points").Points.AddXY(x, y);
            } else {
                object[] pars = { x, y, part };
                Invoke(new IntegralProcessor.ToDraw(DrawPoint), pars);
            }
        }

        async private void button1_Click(object sender, EventArgs e) {
            chart1.Series[0].Points.Clear();
            if (chart1.Series.FindByName("Hists") != null)
                chart1.Series["Hists"].Points.Clear();
            if (chart1.Series.FindByName("Points") != null)
                chart1.Series["Points"].Points.Clear();
            for (int i = 0; i < Environment.ProcessorCount; i++) {
                if (chart1.Series.FindByName("Thread №" + i.ToString()) != null) {
                    chart1.Series["Thread №" + i.ToString()].Points.Clear();
                }
            }
            IntegralProcessor iProcessor = new IntegralProcessor(F);
            switch (comboBox1.Text) {
                case "Rectangular": {
                        if (chart1.Series.FindByName("Hists") == null) {
                            chart1.Series.Add("Hists");
                            chart1.Series["Hists"]["PointWidth"] = "1";  
                        }
                           
                       
                        drawGraphic(Decimal.ToDouble(LowerBoundRectVal.Value), Decimal.ToDouble(UpperBoundRectVal.Value), 0);
                        iProcessor.EventProgress += OnProgress;
                        iProcessor.EventProgress += OnProgressValue;
                        iProcessor.EventFinish += OnFinishTime;
                        if (checkBox1.Checked) iProcessor.EventDraw += DrawHist;
                        iProcessor.EventFinish += OnFinish;
                        await Task.Run(()=> iProcessor.RectangularI(Decimal.ToDouble(LowerBoundRectVal.Value), Decimal.ToDouble(UpperBoundRectVal.Value), Decimal.ToInt32(numberOfIterRect.Value)));
                        progressBar1.Value = 0;     
                        break;
                    }
                case "Monte-Carlo(with stratification)": {
                        if (chart1.Series.FindByName("Points") == null) {
                            chart1.Series.Add("Points");
                            chart1.Series.FindByName("Points").ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                            chart1.Series.FindByName("Points").MarkerSize = 2;
                        }
                            
                        drawGraphic(Decimal.ToDouble(LowerBoundMonteVal.Value), Decimal.ToDouble(UpperBoundMonteVal.Value), 0);
                        iProcessor.EventProgress += OnProgress;
                        iProcessor.EventProgress += OnProgressValue;
                        iProcessor.EventFinish += OnFinish;
                        iProcessor.EventFinish += OnFinishTime;
                        if (checkBox1.Checked) iProcessor.EventDraw += DrawPoint;
                        await Task.Run(() => iProcessor.Monte_CarloI(
                            Decimal.ToDouble(LowerBoundMonteVal.Value), 
                            Decimal.ToDouble(UpperBoundMonteVal.Value), 
                            Decimal.ToInt32(ThrowsMultMonteVal.Value),
                            Decimal.ToDouble(SupremumMonteVal.Value),
                            Decimal.ToDouble(InfimumMonteVal.Value),
                            Decimal.ToInt32(NumStratsMonteVal.Value)));
                        progressBar1.Value = 0;
                        break;
                    }
                case "Simpson's method": {
                        for (int i = 0; i < Environment.ProcessorCount; i++) {
                            if (chart1.Series.FindByName("Thread №" + i.ToString()) == null) {
                                chart1.Series.Add("Thread №" + i.ToString());
                                chart1.Series["Thread №" + i.ToString()].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                            }
                        }
                        
                        drawGraphic(Decimal.ToDouble(LowerBoundRectVal.Value), Decimal.ToDouble(UpperBoundRectVal.Value), 0);
                        iProcessor.EventProgress += OnProgress;
                        iProcessor.EventProgress += OnProgressValue;
                        iProcessor.EventFinish += OnFinish;
                        iProcessor.EventFinish += OnFinishTime;
                        if (checkBox1.Checked) iProcessor.EventDraw += drawParabola;
                        await Task.Run(() => iProcessor.SimpsonI(Decimal.ToDouble(LowerBoundRectVal.Value), Decimal.ToDouble(UpperBoundRectVal.Value), Decimal.ToInt32(numberOfIterRect.Value)));
                        //chart1.Series["Simpson"].Sort(PointSortOrder.Ascending, "X");
                        progressBar1.Value = 0;
                        break; 
                    }
            }
        }

        
    }
}
