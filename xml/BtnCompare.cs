﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xml.xml;

namespace xml
{
    
    class BtnCompare
    {
        InterlockButtons InterLoc = new InterlockButtons();
        DevProps Dev = new DevProps();
      public void Compare()
        {
            int flag1 = 0;
            int flag2 = 0;
            foreach (var DevBtn1 in Dev.)
            {
                foreach (var InterlocBtn in PublicValue.interlockButtonsMode)
                {         
                    if (DevBtn1.Name == InterlocBtn.Name)
                    {
                        //PublicValue.DevBtn1.Add(DevBtn1);
                        //PublicValue.InterLocBtn1.Add(InterlocBtn);
                        flag1 = 1;          
                    }
                }
                if (flag1==0)
                {
                    //PublicValue.BtnCompare.Add("DEV中\"" + DevBtn1+ "\"在InterlockButton中不存在");
                    //PublicValue.DevBtn1.Add(DevBtn1);
                    PublicValue.InterLocBtn1.Add(null);
                }
                else
                {
                    flag1 = 0;
                }
            }
            foreach (var InterlocBtn in PublicValue.interlockButtonsMode)
            { 
                foreach (var DevBtn in PublicValue.modelList)
                {
                    if (DevBtn.Name == InterlocBtn.Name)
                    {
                        
                        flag2 = 1;
                    }
                }
                if (flag2 == 0)
                {
                    //PublicValue.BtnCompare.Add("InterlockButton中\"" + InterlocBtn + "\"在DEV中不存在");
                    //PublicValue.DevBtn1.Add(null);
                    //PublicValue.InterLocBtn1.Add(InterlocBtn);
                }
                else
                {
                    flag2 = 0;
                }
            }

        }
    }
}
