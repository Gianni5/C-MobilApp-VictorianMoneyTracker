using System;
using System.Collections.Generic;
using System.Text;

namespace VictorianMoneyTracker2
{
    public class money
    {
        int total = 0;
        public int pound { get; set; } = 0;
        public int crown { get; set; } = 0;
        public int shilling { get; set; } = 0;
        public int pence { get; set; } = 0;
        public int farthing { get; set; } = 0;


        // this is my convertion rate
        public int poundToCrownConvert { get; set; } = 4;
        public int crownToShilingConvert { get; set; } = 5;
        public int shillingToPeneConvert { get; set; } = 12;
        public int penceToFarthingConvert { get; set; } = 4;

        public int crownToPoundConvert { get; set; } = 4;
        public int shillingToCrownConvert { get; set; } = 5;
        public int penceToShillingConvert { get; set; } = 12;
        public int farthingToPenceConvert { get; set; } = 4;

        //******************************************** CONVERT DOWN FUNCTIONS ************************
        public void poundConvertDown() //convert pound to crown 
        {

            pound--;
            crown = crown + poundToCrownConvert;



        }

        public void crownConvertDown() // convert crown to shilling 
        {
            crown--;
            shilling = shilling + crownToShilingConvert;
        }

        public void shillingConvertDown() // convert shilling to pence
        {
            shilling--;
            pence = pence + shillingToPeneConvert;

        }

        public void penceConvertDown() // convert pence to farthing 
        {
            pence--;
            farthing = farthing + penceToFarthingConvert;


        }

        //************************************ CONVERT UP FUNCTIONS **********************************

        public void crownsConvertUp() // convert crown to pound 
        {

            crown = crown - crownToPoundConvert;
            pound++;


        }

        public void shillingConvertUp() // convert shilling to crown
        {
            shilling = shilling - shillingToCrownConvert;
            crown++;

        }

        public void penceConvertUp() // convert pence to shilling 
        {
            pence = pence - penceToShillingConvert;
            shilling++;

        }

        public void farthingConvertUp() // convert farthing to pence 
        {
            farthing = farthing - farthingToPenceConvert;
            pence++;
        }

        //*************************** MINUS BUTTONS ************************************************

        public void farthingMinus()
        {
            farthing--;
            
        }

        public void penceMinus()
        {
            pence--;
        }

        public void shillingMinus()
        {
           
            shilling--;
        }

        public void crownMinus()
        {
            crown--;
        }

        public void poundMinus()
        {
            pound--;
        }

        //******************************* PLUS BUTTONS *************************************

        public void farthingPlus()
        {
            farthing++;
            //pence--;
        }

        public void pencePlus()
        {
            pence++;
        }

        public void shillingPlus()
        {
            shilling++;
        }

        public void crownPlus()
        {
            crown++;
        }

        public void poundPlus()
        {
            pound++;
        }
    }
}
