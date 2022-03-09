using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VictorianMoneyTracker2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        money Money = new money(); //  object for money class 

        public MainPage()
        {
            InitializeComponent();






        }

        //*************************************** POUND *******************************************
        private void PlusPound_Clicked(object sender, EventArgs e)
        {

            Money.poundPlus();
            updateUI();

        }

        private void poundDown_Clicked(object sender, EventArgs e)//********** POUND DOWN *****************
        {

            Money.poundConvertDown();
            updateUI();

        }

        private void MinuesPound_Clicked(object sender, EventArgs e)
        {

            Money.poundMinus();
            updateUI();
        }
       

        //************************************ CROWN **********************************************

        private void PlusCrown_Clicked(object sender, EventArgs e) 
        {

            Money.crownPlus();
            updateUI();
        }

        private void crownUp_Clicked(object sender, EventArgs e)//***************** CROWN UP ***********
        {


            Money.crownsConvertUp();
            updateUI();

        }

        private void crownDown_Clicked(object sender, EventArgs e)//***************** CROWN DOWN *********
        {

            Money.crownConvertDown();
            updateUI();

        }

        private void MinuesCrown_Clicked(object sender, EventArgs e)
        {

            Money.crownMinus();
            updateUI();
        }

       


        //****************************************** SHILLING ****************************************

        private void PlusShilling_Clicked(object sender, EventArgs e)
        {

            Money.shillingPlus();
            updateUI();
        }

        private void shillUp_Clicked(object sender, EventArgs e)//******** SHILLING UP ***************
        {
            Money.shillingConvertUp();
            updateUI();
        }

        private void shillDown_Clicked(object sender, EventArgs e)//********************* SHILLING DOWN *********
        {

            Money.shillingConvertDown();
            updateUI();


        }

        private void MinuesShilling_Clicked(object sender, EventArgs e)
        {

            Money.shillingMinus();
            updateUI();
        }


        //************************************* PENCE *********************************************

        private void PlusPence_Clicked(object sender, EventArgs e)
        {

            Money.pencePlus();
            updateUI(); //butt
            
            // link xamarin to c#
            penceNum.Text = Money.pence.ToString();            
        }

        private void penceUp_Clicked(object sender, EventArgs e)// **************** PENCE UP *******************
        {
            Money.penceConvertUp();
            updateUI();
            penceNum.Text = Money.pence.ToString();
        }



        private void penceDown_Clicked(object sender, EventArgs e)// **************** PENCE DOWN **************
        {
            Money.penceConvertDown();
            updateUI();

        
        }

        private void MinuesPence_Clicked(object sender, EventArgs e)
        {

            Money.penceMinus();
            updateUI();
            
        }

        //********************************* FARTHING **************************************
        public void PlusFarthingBottonClick(object sender, EventArgs e)
        {

            Money.farthingPlus();
            updateUI();
        }
        private void farthUp_Clicked(object sender, EventArgs e)// ********************** FARTHING UP **********
        {

            Money.farthingConvertUp();
            updateUI();

        }

        private void MinuesFarth_Clicked(object sender, EventArgs e)
        {

            Money.farthingMinus();
            updateUI();

        }




        public void updateUI()
        {
            //******************************* POUND ************************************
            poundNum.Text = Money.pound.ToString();  // link xamarin to c#

            if (Money.pound == 0)
            {
                MinuesPound.IsEnabled = false;
                poundDown.IsEnabled = false;
                poundDown.Source = "downArrowDisabled.png";
            }
            else
            {
                MinuesPound.IsEnabled = true;
                poundDown.IsEnabled = true;
                poundDown.Source = "downArrowEnabled.png";
            }

            //************************** CROWN **************************************
            crownNum.Text = Money.crown.ToString();   // link xamarin to c#

            if (Money.crown < Money.crownToPoundConvert)
            {
                crownUp.IsEnabled = false;
                crownUp.Source = "upArrowDisabled.png";

            }
            else 
            {
                crownUp.IsEnabled = true;
                crownUp.Source = "upArrowEnabled.png";
            }

            if (Money.crown == 0)
            {
                MinuesCrown.IsEnabled = false;
                crownDown.IsEnabled = false;
                crownDown.Source = "downArrowDisabled.png";
            }
            else 
            {
                MinuesCrown.IsEnabled = true;
                crownDown.IsEnabled = true;
                crownDown.Source = "downArrowEnabled.png";
            }



            //****************************** SHILLING ******************************
            shillNum.Text = Money.shilling.ToString();   // link xamarin to c#

            if (Money.shilling < Money.shillingToCrownConvert)
            {
                shillUp.IsEnabled = false;
                shillUp.Source = "upArrowDisabled.png";
            }
            else
            {
                shillUp.IsEnabled = true;
                shillUp.Source = "upArrowEnabled.png";
            }

            if (Money.shilling == 0)
            {
                MinuesShilling.IsEnabled = false;
                shillDown.IsEnabled = false;
                shillDown.Source = "downArrowDisabled.png";
            }
            else
            {
                MinuesShilling.IsEnabled = true;
                shillDown.IsEnabled = true;
                shillDown.Source = "downArrowEnabled.png";
            }


            //**************************** PENCE ******************************************* 
            penceNum.Text = Money.pence.ToString();   // link xamarin to c#

            if (Money.pence < Money.penceToShillingConvert)
            {
                penceUp.IsEnabled = false;
                penceUp.Source = "upArrowDisabled.png";
            }
            else
            {
                penceUp.IsEnabled = true;
                penceUp.Source = "upArrowEnabled.png";
            }
            if (Money.pence == 0)
            {
                MinuesPence.IsEnabled = false;
                penceDown.IsEnabled = false;
                penceDown.Source = "downArrowDisabled.png";
            }
            else
            {
                MinuesPence.IsEnabled = true;
                penceDown.IsEnabled = true;
                penceDown.Source = "downArrowEnabled.png";
            }



            //**************************** FARTHING **********************************
            farthNum.Text = Money.farthing.ToString();  // link xamarin to c#
            
            if (Money.farthing < Money.farthingToPenceConvert)
            {
                farthUp.IsEnabled = false;
                farthUp.Source = "upArrowDisable.png";
            }
            else
            {
                farthUp.IsEnabled = true;
                farthUp.Source = "upArrowEnable.png";
            }

            if (Money.farthing == 0)
            {
                MinuesFarth.IsEnabled = false;
            }
            else 
            {
                MinuesFarth.IsEnabled = true;
            }


        }
    }
}
