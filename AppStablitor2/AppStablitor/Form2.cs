using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AppStablitor
{
    public partial class Form2 : Form
    {
        // Переменные для отслеживания
        double x1= 0;
        double y1 = 0;
        //-------------------
        // Передаем ид и строку подключения
        int id = Form1.indUser;
        static string connectionString = Form1.connectionString;
        SqlConnection con = new SqlConnection(connectionString);
        //-------------------
        //Создаем класс для хранения данных
        public class dataXY 
        {
            public double minx1, minx2, maxx1, maxx2, miny1, miny2, maxy1, maxy2;
            public double avvx1, avvx2, avvy1, avvy2;
            public long counter, leftErr, rightErr, upErr, downErr;
            public dataXY(double minx1, double minx2, double maxx1, double maxx2, double miny1, double miny2, double maxy1, double maxy2, double avvx1, double avvx2, double avvy1, double avvy2, long counter, long leftErr, long rightErr, long upErr, long downErr) 
            {
                this.minx1 = Math.Round(minx1,2);
                this.minx2 = Math.Round(minx2,2);
                this.miny1 = Math.Round(miny1,2);
                this.miny2 = Math.Round(miny2,2);

                this.maxx1 = Math.Round(maxx1,2);
                this.maxx2 = Math.Round(maxx2,2);
                this.maxy1 = Math.Round(maxy1,2);
                this.maxy2 = Math.Round(maxy2,2);

                this.avvx1 = Math.Round(avvx1,2);
                this.avvx2 = Math.Round(avvx2,2);
                this.avvy1 = Math.Round(avvy1,2);
                this.avvy2 = Math.Round(avvy2,2);

                this.counter = counter;
                this.leftErr = leftErr;
                this.rightErr = rightErr;
                this.upErr = upErr;
                this.downErr = downErr;
            }
            // Метод вывода информации
            public string WriteData() 
            {
                string str = "Mx x1=" + maxx1.ToString() + "| ";
                str += "Mx x2=" + maxx2.ToString() + "| ";
                str += "Mx y1=" + maxy1.ToString() + "| ";
                str += "Mx y2=" + maxy2.ToString() + "| ";
                str += "Mn x1=" + minx1.ToString() + "| ";
                str += "Mn x2=" + minx2.ToString() + "| ";
                str += "Mn y1=" + miny1.ToString() + "| ";
                str += "Mn y2=" + miny2.ToString() + "| ";
                str += "Av x1=" + avvx1.ToString() + "| ";
                str += "Av x2=" + avvx2.ToString() + "| ";
                str += "Av y1=" + avvy1.ToString() + "| ";
                str += "Av y2=" + avvy2.ToString() + "| ";
                str += "cnt =" + counter.ToString() + "| ";
                str += "lEr =" + leftErr.ToString() + "| ";
                str += "rEr =" + rightErr.ToString() + "| ";
                str += "uEr =" + upErr.ToString() + "| ";
                str += "dEr =" + downErr.ToString() + "| ";
                return str;
            }
        }
        //===================
        // Списки данных и точек
        List<double> xx1 = new List<double>();
        List<double> yy1 = new List<double>();
        //--------
        long leftErr = 0;
        long rightErr = 0;
        long upErr = 0;
        long downErr = 0;
        long counterStep = 0;
        //==================
        // Список хранения данных и представления в архиве
        List<dataXY> dataSave = new List<dataXY>();
        List<dataXY> dataArhiv = new List<dataXY>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Чистим графики
            graphStabl.Series[0].Points.Clear();
            //-------------------
            try 
            {
                // Считываем данные для отображения фамилии
                con.Open();
                string sqlString = "SELECT * FROM users WHERE id = " + id;
                SqlCommand comm = new SqlCommand(sqlString, con);
                SqlDataReader reader = comm.ExecuteReader();
                //------------
                object fio = "";
                while (reader.Read()) // построчно считываем данные
                {
                    fio = reader.GetValue(3);
                }

                Text = fio.ToString();
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибки - " + ex.ToString());
            }
            finally 
            {
                con.Close();    
            }
        }
        // Эмуляция СТарт и стоп
        private void button1_Click(object sender, EventArgs e)
        {
            if (!tmStart.Enabled)
            {
                tmStart.Start();
                btStabl.Text = "Остановить эмуляцию";
            }
            else 
            {
                tmStart.Stop();
                btStabl.Text = "Запустить эмуляцию";
            }
        }
        // Таймер эмуляции балансирования
        private void tmStart_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            // Рандомные точки
            x1 += rnd.Next(-1, 2) * 0.1 + (double)nmx1.Value;
            y1 += rnd.Next(-1, 2) * 0.1 + (double)nmy1.Value;

            graphStabl.Series[0].Points.Clear();
            graphStabl.Series[0].Points.AddXY(x1, y1);
            graphStabl.Series[0].Points[0].Color = Color.Blue;


            xx1.Add(x1);
            yy1.Add(y1);

            refreshData();
        }
        // Обновление данных
        public void refreshData() 
        {
            bool errorOn = false;
            lstData.Items.Clear();
            lstData.Items.Add("Максимальный x1 : " + Math.Round(xx1.Max(),2).ToString());
            lstData.Items.Add("Минимальный x1 : " + Math.Round(xx1.Min(), 2).ToString());
            //===============================
            lstData.Items.Add("Максимальный y1 : " + Math.Round(yy1.Max(), 2).ToString());
            lstData.Items.Add("Минимальный y1 : " + Math.Round(yy1.Min(), 2).ToString());
            //===============================
            lstData.Items.Add("Средний x1 : " + Math.Round(xx1.Average(), 2).ToString());
            lstData.Items.Add("Средний y1 : " + Math.Round(yy1.Average(), 2).ToString());
            lstData.Items.Add("------------------------------------------");
            //===============================
            // Вывод рекомендаций при ошибке
            if ((x1 <= (double)nmMinx1.Value)) 
            {
                errorOn = true;
                statRecomend("Берите правее!", Color.Red);
                leftErr++;
            }
            if ((x1 >= (double)nmMaxx1.Value)) 
            {
                errorOn = true;
                statRecomend("Берите левее!", Color.Red);
                rightErr++;
            }
            if ((y1 <= (double)nmMiny1.Value)) 
            {
                errorOn = true;
                statRecomend("Берите вперед!", Color.Red);
                downErr++;
            }
            if ((y1 >= (double)nmMaxy1.Value)) 
            {
                errorOn = true;
                statRecomend("Берите назад!", Color.Red);
                upErr++;
            }
            //--------
            if (!errorOn) statRecomend("Все отлично!", Color.Green);
            counterStep++;
            //================================
            lstData.Items.Add("------------------------------------------");
            //lstData.Items.Add("Шаг : " + counterStep.ToString());
            lstData.Items.Add("% ошибки левой стороны : " + Math.Round((double)((double)leftErr / (double)counterStep *100.0),0).ToString());
            lstData.Items.Add("% ошибки правой стороны : " + Math.Round((double)((double)rightErr / (double)counterStep * 100.0), 0).ToString());
            lstData.Items.Add("% ошибки передней стороны : " + Math.Round((double)((double)upErr / (double)counterStep * 100.0), 0).ToString());
            lstData.Items.Add("% ошибки задней стороны : " + Math.Round((double)((double)downErr / (double)counterStep * 100.0), 0).ToString());
        }
        // Сброс координат
        private void btReset_Click(object sender, EventArgs e)
        {
            x1 = 0;
            y1 = 0;
            nmx1.Value = 0;
            nmy1.Value = 0;
        }
        // Изменнеия цвета и текста при рекомендациях
        public void statRecomend(string str, Color clr) 
        {
            lbStat.ForeColor = clr;
            lbStat.Text = str;
        }
        // Добавить в список данные
        private void btAddList_Click(object sender, EventArgs e)
        {
            if (xx1.Count > 0) 
            {
                dataSave.Add(new dataXY(xx1.Min(), 0, xx1.Max(), 0, yy1.Min(), 0, yy1.Max(), 0, xx1.Average(), 0, yy1.Average(), 0, counterStep, leftErr, rightErr, upErr, downErr));
                lstStat.Items.Add(dataSave[dataSave.Count - 1].WriteData());
            }
        }
        // Сброс данных
        private void btClear_Click(object sender, EventArgs e)
        {
            xx1.Clear();
            yy1.Clear();
            counterStep = 0;
            leftErr = 0;
            rightErr = 0;
            upErr = 0;
            downErr = 0;
            lstData.Items.Clear();
        }
        // Добавление данных в бд
        private void btSave_Click(object sender, EventArgs e)
        {
            if (lstStat.Items.Count > 0) 
            {
                bool errorSql = false;
                foreach (dataXY data in dataSave) 
                {
                    string str = @"INSERT INTO data(userId, date, minx1, maxx1, minx2, maxx2, miny1, maxy1, miny2, maxy2, avvx1, avvx2, avvy1, avvy2, counter, leftErr, rightErr, upErr, downErr) " +
                                           @"VALUES(@userId,@date,@minx1,@maxx1,@minx2,@maxx2,@miny1,@maxy1,@miny2,@maxy2,@avvx1,@avvx2,@avvy1,@avvy2,@counter,@leftErr,@rightErr,@upErr,@downErr)";
                    //--------------------
                    try 
                    {
                        con.Open();
                        SqlCommand com = new SqlCommand(str, con);
                        com.Parameters.AddWithValue("@userId", id);
                        com.Parameters.AddWithValue("@date", DateTime.Now);
                        com.Parameters.AddWithValue("@minx1", data.minx1);
                        com.Parameters.AddWithValue("@maxx1", data.maxx1);
                        com.Parameters.AddWithValue("@minx2", data.minx2);
                        com.Parameters.AddWithValue("@maxx2", data.maxx2);
                        com.Parameters.AddWithValue("@miny1", data.miny1);
                        com.Parameters.AddWithValue("@maxy1", data.maxy1);
                        com.Parameters.AddWithValue("@miny2", data.miny2);
                        com.Parameters.AddWithValue("@maxy2", data.maxy2);
                        com.Parameters.AddWithValue("@avvx1", data.avvx1);
                        com.Parameters.AddWithValue("@avvx2", data.avvx2);
                        com.Parameters.AddWithValue("@avvy1", data.avvy1);
                        com.Parameters.AddWithValue("@avvy2", data.avvy2);
                        com.Parameters.AddWithValue("@counter", data.counter);
                        com.Parameters.AddWithValue("@leftErr", data.leftErr);
                        com.Parameters.AddWithValue("@rightErr", data.rightErr);
                        com.Parameters.AddWithValue("@upErr", data.upErr);
                        com.Parameters.AddWithValue("@downErr", data.downErr);
                        int number = com.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибки - " + ex.ToString());
                        errorSql = true;
                    }
                    finally
                    {
                        con.Close();
                    }
                }  
                if (!errorSql) MessageBox.Show("Данные добавлены!");
            }
        }
        // ОЧистка списка данных
        private void BtClearAll_Click(object sender, EventArgs e)
        {
            lstStat.Items.Clear();
        }
        // При выборе данных отображения информации
        private void mpPick_DateSelected(object sender, DateRangeEventArgs e)
        {          
            try
            {
                con.Open();
                lstArhiv.Items.Clear();
                lstInfo.Items.Clear();
                dataArhiv.Clear();
                string sql = $"SELECT * FROM data WHERE (userId = {id}) AND (date BETWEEN '{mpPick.SelectionRange.Start:yyyy-dd-MM} 00:00:00' AND '{mpPick.SelectionRange.End:yyyy-dd-MM} 23:59:59')";
                SqlCommand comm = new SqlCommand(sql, con);
                SqlDataReader rd = comm.ExecuteReader();
                //------------
                while (rd.Read()) // построчно считываем данные
                {
                    dataArhiv.Add(new dataXY((double)rd.GetValue(3),(double)rd.GetValue(4),(double)rd.GetValue(5),(double)rd.GetValue(6),(double)rd.GetValue(7),(double)rd.GetValue(8),(double)rd.GetValue(9),(double)rd.GetValue(10),(double)rd.GetValue(11),(double)rd.GetValue(12),(double)rd.GetValue(13),(double)rd.GetValue(14),(int)rd.GetValue(15), (int)rd.GetValue(16), (int)rd.GetValue(17), (int)rd.GetValue(18), (int)rd.GetValue(19)));
                    lstArhiv.Items.Add(dataArhiv[dataArhiv.Count - 1].WriteData());
                }
                rd.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибки - " + ex.ToString());
            }
            finally 
            {
                con.Close();
            }
        }
        // Информация на вкладки архив
        private void lstArhiv_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = lstArhiv.SelectedIndex;
            lstInfo.Items.Clear();
            var obj = dataArhiv[ind];

            lstInfo.Items.Add("Максимальный x1 : " + obj.maxx1.ToString());
            lstInfo.Items.Add("Минимальный x1 : " + obj.minx1.ToString());

            lstInfo.Items.Add("Максимальный y1 : " + obj.maxy1.ToString());
            lstInfo.Items.Add("Минимальный y1 : " + obj.miny1.ToString());
            lstInfo.Items.Add("------------------------------------------");
            lstInfo.Items.Add("------------------------------------------");
            lstInfo.Items.Add("Средний x1 : " + obj.avvx1.ToString());
            lstInfo.Items.Add("Средний y1 : " + obj.avvy1.ToString());
            lstInfo.Items.Add("------------------------------------------");
            lstInfo.Items.Add("Шаг : " + obj.counter.ToString());
            lstInfo.Items.Add("% ошибки левой стороны : " + Math.Round((double)((double)obj.leftErr / (double)obj.counter * 100.0), 0).ToString());
            lstInfo.Items.Add("% ошибки правой стороны : " + Math.Round((double)((double)obj.rightErr / (double)obj.counter * 100.0), 0).ToString());
            lstInfo.Items.Add("% ошибки передней стороны : " + Math.Round((double)((double)obj.upErr / (double)obj.counter * 100.0), 0).ToString());
            lstInfo.Items.Add("% ошибки задней стороны : " + Math.Round((double)((double)obj.downErr / (double)obj.counter * 100.0), 0).ToString());
            //===========================
            // Отображение диаграммы
            graphStart.ChartAreas.Clear();
            graphStart.Series.Clear();

            ChartArea chArea = new ChartArea("Статистика");
            chArea.AxisX.Title = "Ошибки";
            chArea.AxisY.Title = "Сравнение ошибок и шагов";
            
            graphStart.ChartAreas.Add(chArea);

            Series s1 = new Series();
            s1.AxisLabel = "Шаги";
            var dp1 = s1.Points.Add(obj.counter);
            graphStart.Series.Add(s1);

            Series s2 = new Series();
            s2.AxisLabel = "Левая";
            var dp2 = s2.Points.Add(obj.leftErr);
            graphStart.Series.Add(s2);

            Series s3 = new Series();
            s3.AxisLabel = "Правая";
            var dp3 = s3.Points.Add(obj.rightErr);
            graphStart.Series.Add(s3);

            Series s4 = new Series();
            s4.AxisLabel = "Перед";
            var dp4 = s4.Points.Add(obj.upErr);
            graphStart.Series.Add(s4);

            Series s5 = new Series();
            s5.AxisLabel = "Зад";
            var dp5 = s5.Points.Add(obj.downErr);
            graphStart.Series.Add(s5);

            graphStart.AlignDataPointsByAxisLabel();
        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
