using System;
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
            foreach (string DevBtn1 in PublicValue.DevBtn)
            {
                foreach (var InterlocBtn in PublicValue.InterLocBtn)
                {         
                    if (DevBtn1 == InterlocBtn)
                    {
                        //PublicValue.BtnCompare.Add(InterlocBtn +"="+ DevBtn);
                        //PublicValue.BtnCompare.Add("InterlockButton中\"" + InterlocBtn + "\"在DEV中不存在");
                        flag1 = 1;          
                    }
                }
                if (flag1==0)
                {
                    PublicValue.BtnCompare.Add("DEV中\"" + DevBtn1+ "\"在InterlockButton中不存在");
                }
                else
                {
                    flag1 = 0;
                }
            }
            foreach (var InterlocBtn in PublicValue.InterLocBtn)
            { 
                foreach (string DevBtn in PublicValue.DevBtn)
                {
                    if (DevBtn == InterlocBtn)
                    {
                        //PublicValue.BtnCompare.Add(InterlocBtn +"="+ DevBtn);
                        //PublicValue.BtnCompare.Add("InterlockButton中\"" + InterlocBtn + "\"在DEV中不存在");
                        flag2 = 1;
                    }
                }
                if (flag2 == 0)
                {
                    PublicValue.BtnCompare.Add("InterlockButton中\"" + InterlocBtn + "\"在DEV中不存在");
                }
                else
                {
                    flag2 = 0;
                }
            }

        }
    }
}
