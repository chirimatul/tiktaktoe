using Microsoft.VisualStudio.TestTools.UnitTesting;
using signalR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace signalR.Tests
{
    [TestClass]
    public class testcases
    {

        [TestMethod]
        public void GetWinner()
        {
            Tiktaktoe t = new Tiktaktoe();
            int?[,] a = new int?[3, 3] {
                {null, null, null} , 
                {null, null, null} ,
                {null, null, null}
            };
            var res = t.GetWinner(a);

            a = new int?[3, 3] {
                {1, 1, 1} , 
                {null, null, null} ,
                {null, null, null}
            };
            res = t.GetWinner(a);

            a = new int?[3, 3] {
                {null, null, null} , 
                {2, 2, 2} ,
                {null, null, null}
            };
            res = t.GetWinner(a);

            a = new int?[3, 3] {
                {null, 1, null} , 
                {null, 1, null} ,
                {null, 1, null}
            };
            res = t.GetWinner(a);

            a = new int?[3, 3] {
                {null, null, 2} , 
                {null, null, 2} ,
                {null, null, 2}
            };
            res = t.GetWinner(a);

            a = new int?[3, 3] {
                {1, null, null} , 
                {null, 1, null} ,
                {null, null, 1}
            };
            res = t.GetWinner(a);

            a = new int?[3, 3] {
                {null, null, 2} , 
                {null, 2, null} ,
                {2, null, null}
            };
            res = t.GetWinner(a);

            a = new int?[3, 3] {
                {1, 2, 1} , 
                {1, 2, 2} ,
                {2, 1, 1}
            };
            res = t.GetWinner(a);

            a = new int?[3, 3] {
                {1, 1, 2} , 
                {2, 2, 1} ,
                {1, 2, 1}
            };
            res = t.GetWinner(a);

            a = new int?[3, 3] {
                {null, null, null} , 
                {null, null, null} ,
                {null, null, null}
            };
            res = t.GetWinner(a);

            a = new int?[3, 3] {
                {null, null, null} , 
                {null, null, null} ,
                {null, null, null}
            };
            res = t.GetWinner(a);



        }
    }
}
