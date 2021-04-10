using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [StructLayout(LayoutKind.Sequential)]
        public class Calculator
        {
            public int SizeOf()
            {
                throw new NotImplementedException("Not implemented");
            }
            public void Print()
            {
                MessageBox.Show("Print");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {



            string s1 = "*Sie";

            string s2 = s1.Insert(3, "em");

            string s3 = s2.Insert(6, "ns*");

            for (int i = 0; i < s3.Length; i++)

                MessageBox.Show(s3[i].ToString().ToUpper());

            

            /*
            Calculator objA = new Calculator();
            int size = Marshal.SizeOf(typeof(Calculator));
            MessageBox.Show(size + "");


         

           int num = 0;
           (num++);
           MessageBox.Show(num.ToString());



           * 
          int a = 10;
          try
          {
              int result = a / 0;
          }
          catch (Exception ex)
          {
              MessageBox.Show(" General Exception occurred in Main.");
          }
          catch (DivideByZeroException ed)
          {
              MessageBox.Show("Div by Zero Exception occurred in Main.");
          }


           * 
           * 
        try
        {
            MessageBox.Show("In Try ...");
            throw new Exception();
        }
        catch
        {
            MessageBox.Show("In Catch ...");
            Environment.Exit(0);
        }
        finally
        {
            MessageBox.Show("In Finally...");
        }
        MessageBox.Show("End...");
    }


    ListView lv = new ListView();

    MessageBox.Show(Math.Round(6.5).ToString());
    MessageBox.Show(Math.Round(13.5).ToString());

               float num = 0, div = 0;

    try
    {
        MessageBox.Show((num / div).ToString());
    }
    catch (DivideByZeroException)
    {
        MessageBox.Show("Division By Zero");
    }

    string str = "Hello World!";

    MessageBox.Show(String.Compare(str, "Hello World?").GetType().ToString());
    */
        }
    }
}