using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using DDS;
using DDS.OpenSplice;
using HelloWorldData;
using DDSAPIHelper;
using System.IO;



namespace GmapTest
{
    // Define global variable
    public static class GlobalData
    {
        public static bool ischanged = false;
        public static double upleft_lat;
        public static double upleft_lng;
        public static double btmright_lat;
        public static double btmright_lng;
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Thread thr_DDS_Worker = new Thread(new ThreadStart(Program.OpenSpliceWorker));
            Thread thr_DDS_Worker = new Thread(() => OpenSpliceWorker(Form1.ActiveForm));
            thr_DDS_Worker.Start();
            //Thread thr_DDS_Worker = new Thread(new ThreadStart(Program.OpenSpliceWorker));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }


        // Create the DDS worker thread here.
        public static void OpenSpliceWorker(Form mainForm)
        {// Initialize the DDS Code first
            bool done = false;

            DDSEntityManager mgr = new DDSEntityManager("HelloWorld");
            String partitionName = "HelloWorld example";

            // create Domain Participant
            mgr.createParticipant(partitionName);
            mgr.setAutoDispose(false);

            // create Type
            MsgTypeSupport msgTS = new MsgTypeSupport();
            mgr.registerType(msgTS);

            // create Topic
            mgr.createTopic("HelloWorldData_Msg");

            // create Publisher
            mgr.createPublisher();

            // create DataWriter
            mgr.createWriter();

            // Publish Events
            IDataWriter dwriter = mgr.getWriter();
            MsgDataWriter helloWorldWriter = dwriter as MsgDataWriter;

            Msg msgInstance = new Msg();
            msgInstance.userID = 1;
            msgInstance.message = "Update Locations"; // "Hello World";

            InstanceHandle handle = helloWorldWriter.RegisterInstance(msgInstance);
            ErrorHandler.checkHandle(handle, "MsgDataWriter.RegisterInstance");

            Console.WriteLine("=== [Publisher] writing a message containing :");
            Console.WriteLine("    userID  : {0}", msgInstance.userID);
            Console.WriteLine("    Message : \" {0} \"", msgInstance.message);
            ReturnCode status = helloWorldWriter.Write(msgInstance, handle);
            ErrorHandler.checkStatus(status, "MsgDataWriter.Write");

            // main write loop here...
            //try
            //{
            //    Thread.Sleep(2);
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //    Console.WriteLine(ex.StackTrace);
            //}
            while (!done)
            {// sleep and write samples from the main screen.
                Thread.Sleep(500);
                if (GlobalData.ischanged == true)
                {// main thread has written data values, so update data
                    msgInstance.lattitued_ul = GlobalData.upleft_lat;
                    msgInstance.longitude_ul = GlobalData.upleft_lng;
                    msgInstance.lattitude_lr = GlobalData.btmright_lat;
                    msgInstance.longitude_lr = GlobalData.btmright_lng;
                    GlobalData.ischanged = false;
                    Console.WriteLine("Upper left Lat" + msgInstance.lattitued_ul.ToString());
                    Console.WriteLine("Upper left Lng" + msgInstance.longitude_ul.ToString());
                    Console.WriteLine("Lower Right Lat" + msgInstance.lattitude_lr.ToString());
                    Console.WriteLine("Lower Right Lng" + msgInstance.longitude_lr.ToString());
                    ReturnCode dds_status = helloWorldWriter.Write(msgInstance, handle);
                    ErrorHandler.checkStatus(dds_status, "MsgDataWriter.Write");
                }
            }

            // end of main write loop

            // Clean up
            status = helloWorldWriter.UnregisterInstance(msgInstance, handle);

            mgr.getPublisher().DeleteDataWriter(helloWorldWriter);
            mgr.deletePublisher();
            mgr.deleteTopic();
            mgr.deleteParticipant();

            return;
        }
    }
}
