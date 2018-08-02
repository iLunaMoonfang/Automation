﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Automation;
using ConsoleApp1.Common;
using ConsoleApp1.DataModel;

namespace ConsoleApp1
{
    class Program
    {
        static AutomationElement buyWindowsElement;
        static void Main(string[] args)
        {
          




        }

       

        /// <summary>
        /// 中投证券买入窗口Demo
        /// </summary>
        /// <param name="_elemet">模块元素节点</param>
        static void ZTbuyWindowsElementDemo()
        {
            var uielement = new iAutomationElement();
            var elementlist = uielement.enumRoot();
            elementlist = uielement.FindByName("中投证券", elementlist);
            elementlist = uielement.enumNode(elementlist[0]);
            if (elementlist.Count > 1)
            {
                foreach (AutomationElement item in elementlist)
                {
                    var list = uielement.enumDescendants(item, "买入下单");
                    if (list.Count > 0)
                    {
                        buyWindowsElement = TreeWalker.RawViewWalker.GetParent(list[0]);
                        elementlist = uielement.enumNode(buyWindowsElement);
                        elementlist = uielement.FindByClassName("AfxWnd42", elementlist);
                        uielement.WriteTextBox(elementlist[0], "\b\b\b\b\b\b");
                        uielement.WriteTextBox(elementlist[0], "000005");
                    }
                }
            }

        }
        /// <summary>
        /// 中投证券卖出窗口Demo
        /// </summary>
        static void ZTsaleWindowsElementDemo()
        {
            var uielement = new iAutomationElement();
            var elementlist = uielement.enumRoot();
            elementlist = uielement.FindByName("中投证券", elementlist);
            elementlist = uielement.enumNode(elementlist[0]);
            if (elementlist.Count > 1)
            {
                foreach (AutomationElement item in elementlist)
                {
                    var list = uielement.enumDescendants(item, "卖出下单");
                    if (list.Count > 0)
                    {
                        buyWindowsElement = TreeWalker.RawViewWalker.GetParent(list[0]);
                        elementlist = uielement.enumNode(buyWindowsElement);
                        elementlist = uielement.FindByClassName("AfxWnd42", elementlist);
                        uielement.WriteTextBox(elementlist[0], "\b\b\b\b\b\b");
                        uielement.WriteTextBox(elementlist[0], "000005");
                    }
                }
            }
        }


        /// <summary>
        /// 之前的测试代码垃圾桶
        /// </summary>
        static void zhushi()
        {
            //uielement.enumNode(uielement.node);
            //uielement.FindByClassName("Afx:");
            //Console.WriteLine("--------------------------------------------");
            //uielement.enumNode(uielement.node);
            //AutomationElement ui = uielement.SearchWindowsByName("", "AfxWnd42");
            //if(ui!=null)
            //    uielement.GetViewList(ui,5);



            //AutomationElement ae = AutomationElement.RootElement;
            //StringBuilder sb = new StringBuilder();
            /////获得主窗口ui元素
            //var main = ae.FindFirst(TreeScope.Children, new PropertyCondition(AutomationElement.NativeWindowHandleProperty, Int32.Parse("00AB096A", System.Globalization.NumberStyles.HexNumber)));

            ///// 获得

            //var s2 = main.FindFirst(TreeScope.Subtree, new PropertyCondition(AutomationElement.NativeWindowHandleProperty, Int32.Parse("00090A70", System.Globalization.NumberStyles.HexNumber)));

            //Console.WriteLine(s2.Current.Name);
            ////var s2 = st.FindAll(TreeScope.Descendants, PropertyCondition.TrueCondition);
            //var s3 = s2.FindFirst(TreeScope.Subtree, new PropertyCondition(AutomationElement.NativeWindowHandleProperty, Int32.Parse("00010A72", System.Globalization.NumberStyles.HexNumber)));
            //Console.WriteLine(s3.Current.ClassName);
            //int count = (int)SendMessage((IntPtr)s3.Current.NativeWindowHandle, LVM_GETITEMCOUNT, 0, 0);
            //Console.WriteLine(count);
            //uint vProcessId;
            //GetWindowThreadProcessId((IntPtr)s3.Current.NativeWindowHandle, out vProcessId);

            //IntPtr vProcess = OpenProcess(PROCESS_VM_OPERATION | PROCESS_VM_READ |
            //    PROCESS_VM_WRITE, false, vProcessId);
            //IntPtr vPointer = VirtualAllocEx(vProcess, IntPtr.Zero, 4096,
            //    MEM_RESERVE | MEM_COMMIT, PAGE_READWRITE);

            //for (int i = 0; i < count; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        byte[] vBuffer = new byte[256];
            //        LVITEM[] vItem = new LVITEM[1];
            //        vItem[0].mask = LVIF_TEXT;
            //        vItem[0].iItem = i;
            //        vItem[0].iSubItem = j;
            //        vItem[0].cchTextMax = vBuffer.Length;
            //        vItem[0].pszText = (IntPtr)((int)vPointer + Marshal.SizeOf(typeof(LVITEM)));
            //        uint vNumberOfBytesRead = 0;
            //        WriteProcessMemory(vProcess, vPointer,
            //            Marshal.UnsafeAddrOfPinnedArrayElement(vItem, 0),
            //            Marshal.SizeOf(typeof(LVITEM)), ref vNumberOfBytesRead);
            //        SendMessage((IntPtr)s3.Current.NativeWindowHandle, LVM_GETITEMW, i, vPointer.ToInt32());
            //        ReadProcessMemory(vProcess,
            //            (IntPtr)((int)vPointer + Marshal.SizeOf(typeof(LVITEM))),
            //            Marshal.UnsafeAddrOfPinnedArrayElement(vBuffer, 0),
            //            vBuffer.Length, ref vNumberOfBytesRead);

            //        string vText = Marshal.PtrToStringUni(
            //            Marshal.UnsafeAddrOfPinnedArrayElement(vBuffer, 0));
            //        Console.WriteLine(vText);
            //    }
            //}


            ////var s4 = s3.FindFirst(TreeScope.Subtree, new PropertyCondition(AutomationElement.NativeWindowHandleProperty, Int32.Parse("000D05A6", System.Globalization.NumberStyles.HexNumber)));
            ////Console.WriteLine(s3.Current.ClassName);
            ////var editor = s4[0];
            //////SendMessage(editor.Current.NativeWindowHandle, 0x0102, (IntPtr)50, (IntPtr)0);

            ////InvokeButton(editor);
            ////Console.WriteLine(editor.Current.ClassName);
            ////ValuePattern value = (ValuePattern)editor.GetCurrentPattern(ValuePattern.Pattern);
            ////value.SetValue("100");
            ////var s3 = s2.FindAll(TreeScope.Children, PropertyCondition.TrueCondition);
            ////for (int i = 0; i < main.Count; i++)
            ////{
            ////    Console.WriteLine(main[i].Current.ClassName +"    "+ Convert.ToString(main[i].Current.NativeWindowHandle, 16));
            ////}
        }

        /// <summary>
        /// /模拟点击
        /// </summary>
        /// <param name="e"></param>
        private static void InvokeButton(AutomationElement e)
        {
            InvokePattern invoke = (InvokePattern)e.GetCurrentPattern(InvokePattern.Pattern);
            invoke.Invoke();
        }
        public static string Character(int asc)
        {
            //asc = asc + 65536;
            Encoding asciiEncoding = Encoding.GetEncoding("GB18030");
            Byte[] chrByte = BitConverter.GetBytes((short)asc);
            string strCharacter = string.Empty;
            if (asc < 0 || asc > 255)
            {
                Byte[] chrByteStr = new byte[2];
                chrByteStr[0] = chrByte[1];
                chrByteStr[1] = chrByte[0];
                strCharacter = asciiEncoding.GetString(chrByteStr);
            }
            else
            {
                Byte[] chrByteStr = new byte[1];
                chrByteStr[0] = chrByte[0];
                strCharacter = asciiEncoding.GetString(chrByteStr);
            }
            return (strCharacter);
        }
    }

    
}
