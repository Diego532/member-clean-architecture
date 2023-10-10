using Member.ApplicationLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Member.Presentation
{
    //Despues muevo esta logica al ViewModel
    public partial class MainWindow : Window
    {
        //private readonly ImemberRepository _memberRepository;
        private readonly IMemberServices memberServices;


        public MainWindow(IMemberServices memberServices)
        {
            InitializeComponent();
            //this._memberRepository = memberRepository;
            this.memberServices = memberServices;
           

            try
            {
                //Ya va que... Por que funcioba asi???
                var data2 = memberServices.GetAllMembers();
                Debug.WriteLine("Todo bien candidad de registros: " + data2.ToArray().Length);

            }
            catch (Exception e)
            {

                Debug.WriteLine("Ocurrio un error: " + e);
            }
            
        }
    }
}
