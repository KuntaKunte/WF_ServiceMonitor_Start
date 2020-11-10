using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceProcess;

namespace WF_ServiceMonitor_Start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
           

        }

        public string STATUS;

        async void InfiniteLoop()
        {
            while (true)
            {
                await Task.Delay(5000);
                Tme_Date.Text = DateTime.Now.ToString();
                //STATUS = DateTime.Now.ToString();
               // FDC_STATUS.Text = DateTime.Now.ToString();
              //  await Task.Delay(10000);
              //  FDC_STATUS.Text = "2nd output";
              //  await Task.Delay(10000);

                //******************************************************************************************************************
                 try
                 {
               
                    ServiceController service = new ServiceController("Spooler");

                    //Start the service
                    if (service.Status == ServiceControllerStatus.Stopped)
                    {
                                               
                        FDC_STATUS.Text = "Service Stopped";
                        await Task.Delay(5000);
                        LAST_ST_DT.Text = DateTime.Now.ToString();
                        //Console.WriteLine("Service Not Running");
                        //System.Threading.Thread.Sleep(5000);
                        //await Task.Delay(2000);
                        service.Start();
                        service.WaitForStatus(ServiceControllerStatus.Running, TimeSpan.FromSeconds(10.0));
                    }

                    //Stop the service
                    if (service.Status == ServiceControllerStatus.Running)
                    {
                        FDC_STATUS.Text = "Service Running";
                        await Task.Delay(120000);
                    //Console.WriteLine("Service IS Running");
                   //System.Threading.Thread.Sleep(120000);
                        //await Task.Delay(2000);
                          //  service.Stop();
                          //  service.WaitForStatus(ServiceControllerStatus.Stopped, TimeSpan.FromSeconds(10.0));
                    }
                }
                catch (Exception ex)
                {
                   FDC_STATUS.Text = (ex.Message);
                    // Console.ReadLine();
                }


                //*********************************************************************************************************************            




            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            InfiniteLoop();
        }

        private void FDC_STATUS_Click(object sender, EventArgs e)
        {

        }

        private void Tme_Date_Click(object sender, EventArgs e)
        {
            
        }

        private void LAST_ST_DT_Click(object sender, EventArgs e)
        {

        }
    }
}
