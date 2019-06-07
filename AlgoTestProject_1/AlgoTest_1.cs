using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;

namespace AlgoTestProject_1
{
    [TestClass]
    public class AlgoTest_1
    {
        [TestMethod]
        public void TestEBit_1()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            PowerSet<string> ps2 = new PowerSet<string>();

            ps1.Put(1);
            ps1.Put(83);
            ps1.Put(923);
            ps1.Put(44);
            ps1.Put(9410);
            ps1.Put(642);
            ps1.Put(5);

            ps2.Put("str");
            ps2.Put("cheap");
            ps2.Put("far");
            ps2.Put("hue");

            Assert.AreEqual(true, ps1.Get(5));
            Assert.AreEqual(false, ps2.Get("gg"));
            Assert.AreEqual(true, ps2.Get("far"));
        }


        [TestMethod]
        public void TestEBit_2()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            PowerSet<int> ps2 = new PowerSet<int>();
            PowerSet<string> ps3 = new PowerSet<string>();
            PowerSet<string> ps4 = new PowerSet<string>();

            ps1.Put(1);
            ps1.Put(83);
            ps1.Put(923);
            ps1.Put(44);
            ps1.Put(9410);
            ps1.Put(642);
            ps1.Put(5);

            ps2.Put(3);
            ps2.Put(5);
            ps2.Put(44);
            ps2.Put(187);
            ps2.Put(500);
            ps2.Put(923);
            ps2.Put(601);

            PowerSet<int> psi = ps1.Intersection(ps2);
            Assert.AreEqual(true, psi.Get(5));
            Assert.AreEqual(true, psi.Get(923));
            Assert.AreEqual(true, psi.Get(44));
        }


        [TestMethod]
        public void TestEBit_3()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            PowerSet<int> ps2 = new PowerSet<int>();
            PowerSet<int> ps3 = new PowerSet<int>();

            ps1.Put(1);
            ps1.Put(6);
            ps1.Put(10);
            ps1.Put(8);
            ps1.Put(94);
            ps1.Put(55);

            ps2.Put(55);
            ps2.Put(12);
            ps2.Put(5);
            ps2.Put(100);

            Assert.AreEqual(4, ps2.count);
            Assert.AreEqual(6, ps1.count);

            ps3 = ps1.Union(ps2);

            Assert.AreEqual(true, ps3.Get(1));
            Assert.AreEqual(true, ps3.Get(6));
            Assert.AreEqual(true, ps3.Get(10));
            Assert.AreEqual(true, ps3.Get(8));
            Assert.AreEqual(true, ps3.Get(94));
            Assert.AreEqual(true, ps3.Get(55));
            Assert.AreEqual(true, ps3.Get(12));
            Assert.AreEqual(true, ps3.Get(5));
            Assert.AreEqual(true, ps3.Get(100));
            Assert.AreEqual(false, ps3.Get(2));
            Assert.AreEqual(false, ps3.Get(99));

            Assert.AreEqual(9, ps3.count);
        }


        [TestMethod]
        public void TestEBit_4()
        {
            PowerSet<int> ps1 = new PowerSet<int>();

            ps1.Put(1);
            ps1.Put(83);
            ps1.Put(923);
            ps1.Put(44);
            ps1.Put(9410);
            ps1.Put(642);
            ps1.Put(5);

            Assert.AreEqual(7, ps1.count);
            Assert.AreEqual(true, ps1.Get(1));
            Assert.AreEqual(true, ps1.Get(83));
            Assert.AreEqual(true, ps1.Get(923));
            Assert.AreEqual(true, ps1.Get(44));
            Assert.AreEqual(true, ps1.Get(9410));
            Assert.AreEqual(true, ps1.Get(642));
            Assert.AreEqual(true, ps1.Get(5));

            ps1.Remove(83);

            Assert.AreEqual(6, ps1.count);
            Assert.AreEqual(true, ps1.Get(1));
            Assert.AreEqual(false, ps1.Get(83));
            Assert.AreEqual(true, ps1.Get(923));
            Assert.AreEqual(true, ps1.Get(44));
            Assert.AreEqual(true, ps1.Get(9410));
            Assert.AreEqual(true, ps1.Get(642));
            Assert.AreEqual(true, ps1.Get(5));
        }


        [TestMethod]
        public void TestEBit_5()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            PowerSet<int> ps2 = new PowerSet<int>();

            ps1.Put(1);
            ps1.Put(2);
            ps1.Put(3);
            ps1.Put(6);
            ps1.Put(7);
            ps1.Put(8);
            ps1.Put(9);

            ps2.Put(1);
            ps2.Put(2);
            ps2.Put(3);
            ps2.Put(8);
            
            Assert.AreEqual(true, ps1.IsSubset(ps2));
        }


        [TestMethod]
        public void TestEPut_1()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            PowerSet<string> ps2 = new PowerSet<string>();
            PowerSet<byte> ps3 = new PowerSet<byte>();
            PowerSet<Node> ps4 = new PowerSet<Node>();

            int n1 = 52;
            int n2 = 174;
            int n3 = 9;
            int n4 = 519;
            int n5 = 201;
            int n6 = 111;
            string s1 = "unity";
            string s2 = "log";
            string s3 = "pro";
            string s4 = "joy";
            string s5 = "gin";
            byte b1 = 24;
            byte b2 = 15;
            byte b3 = 100;
            byte b4 = 99;
            Node node1 = new Node();
            Node node2 = new Node();
            Node node3 = new Node();

            ps1.Put(n1);
            ps1.Put(n2);
            ps1.Put(n3);
            ps1.Put(n4);
            ps1.Put(n5);
            ps1.Put(n6);

            ps2.Put(s1);
            ps2.Put(s2);
            ps2.Put(s3);
            ps2.Put(s4);
            ps2.Put(s5);

            ps3.Put(b1);
            ps3.Put(b2);
            ps3.Put(b3);
            ps3.Put(b4);

            ps4.Put(node1);
            ps4.Put(node2);
            ps4.Put(node3);

            Assert.AreEqual(true, ps1.Get(n1));
            Assert.AreEqual(true, ps1.Get(n2));
            Assert.AreEqual(true, ps1.Get(n3));
            Assert.AreEqual(true, ps1.Get(n4));
            Assert.AreEqual(true, ps1.Get(n5));
            Assert.AreEqual(true, ps1.Get(n6));
            Assert.AreEqual(true, ps1.Get(9));
            Assert.AreEqual(false, ps1.Get(10));
            Assert.AreEqual(false, ps1.Get(1112));

            Assert.AreEqual(true, ps2.Get(s1));
            Assert.AreEqual(true, ps2.Get(s2));
            Assert.AreEqual(true, ps2.Get(s3));
            Assert.AreEqual(true, ps2.Get(s4));
            Assert.AreEqual(true, ps2.Get(s5));
            Assert.AreEqual(true, ps2.Get("joy"));
            Assert.AreEqual(false, ps2.Get("jiy"));

            Assert.AreEqual(true, ps3.Get(b1));
            Assert.AreEqual(true, ps3.Get(b2));
            Assert.AreEqual(true, ps3.Get(b3));
            Assert.AreEqual(true, ps3.Get(b4));
            Assert.AreEqual(true, ps3.Get(15));
            Assert.AreEqual(false, ps3.Get(16));
            Assert.AreEqual(false, ps3.Get(14));

            Assert.AreEqual(true, ps4.Get(node1));
            Assert.AreEqual(true, ps4.Get(node2));
            Assert.AreEqual(true, ps4.Get(node3));
            Assert.AreEqual(false, ps4.Get(new Node()));
        }


        [TestMethod]
        public void TestEPut_2()
        {
            PowerSet<int> ps1 = new PowerSet<int>();

            int n1 = 52;
            int n2 = 174;
            int n3 = 9;

            Assert.AreEqual(0, ps1.count);

            ps1.Put(n1);
            ps1.Put(n2);
            ps1.Put(n3);

            Assert.AreEqual(true, ps1.Get(n1));
            Assert.AreEqual(true, ps1.Get(n2));
            Assert.AreEqual(true, ps1.Get(n3));
            Assert.AreEqual(3, ps1.count);

            ps1.Put(9);

            Assert.AreEqual(3, ps1.count);

            for (int i = 200; i < 300; i++)
                ps1.Put(i);

            Assert.AreEqual(103, ps1.count);

            for (int i = 200; i < 300; i++)
                Assert.AreEqual(true, ps1.Get(i));
        }


        [TestMethod]
        public void TestEPut_3()
        {
            PowerSet<string> ps1 = new PowerSet<string>();

            string s1 = "I";
            string s2 = "Fe";
            string s3 = "Cu";
            string s4 = "Mt";

            Assert.AreEqual(0, ps1.count);

            ps1.Put(s1);
            ps1.Put(s2);
            ps1.Put(s3);
            ps1.Put(s4);

            Assert.AreEqual(true, ps1.Get(s1));
            Assert.AreEqual(true, ps1.Get(s2));
            Assert.AreEqual(true, ps1.Get(s3));
            Assert.AreEqual(true, ps1.Get(s4));
            Assert.AreEqual(true, ps1.Get("I"));
            Assert.AreEqual(false, ps1.Get("i"));
            Assert.AreEqual(4, ps1.count);
        }


        [TestMethod]
        public void TestEPut_4()
        {
            PowerSet<bool> ps1 = new PowerSet<bool>();

            bool b1 = false;
            bool b2 = true;
            bool b3 = true;

            Assert.AreEqual(0, ps1.count);

            ps1.Put(b1);
            ps1.Put(b2);
            ps1.Put(b3); // не добавляет

            Assert.AreEqual(true, ps1.Get(b1));
            Assert.AreEqual(true, ps1.Get(b2));
            Assert.AreEqual(true, ps1.Get(b3)); // обнаруживает тот же слот что и b2
            Assert.AreEqual(true, ps1.Get(false));
            Assert.AreEqual(1, ps1.count);
        }


        [TestMethod]
        public void TestEIntersection_1()
        {
            PowerSet<string> ps1 = new PowerSet<string>();
            PowerSet<string> ps2 = new PowerSet<string>();

            ps1.Put("j1");
            ps1.Put("j2");
            ps1.Put("car");
            ps1.Put("far");

            ps2.Put("Pop");
            ps2.Put("far");
            ps2.Put("j2");

            PowerSet<string> ps3 = ps1.Intersection(ps2);

            Assert.AreEqual(true, ps3.Get("far"));
            Assert.AreEqual(true, ps3.Get("j2"));
            Assert.AreEqual(false, ps3.Get("car"));
            Assert.AreEqual(2, ps3.count);
        }


        [TestMethod]
        public void TestEUnion_1()
        {
            PowerSet<string> ps1 = new PowerSet<string>();
            PowerSet<string> ps2 = new PowerSet<string>();

            ps1.Put("j1");
            ps1.Put("j2");
            ps1.Put("car");
            ps1.Put("far");

            ps2.Put("Pop");
            ps2.Put("far");
            ps2.Put("j2");
            ps2.Put("trust");
            ps2.Put("bleach");

            Assert.AreEqual(4, ps1.count);
            Assert.AreEqual(5, ps2.count);

            PowerSet<string> ps3 = ps1.Union(ps2);

            Assert.AreEqual(7, ps3.count);

            Assert.AreEqual(true, ps3.Get("far"));
            Assert.AreEqual(true, ps3.Get("j2"));
            Assert.AreEqual(true, ps3.Get("car"));
            Assert.AreEqual(true, ps3.Get("j1"));
            Assert.AreEqual(true, ps3.Get("Pop"));
            Assert.AreEqual(true, ps3.Get("trust"));
            Assert.AreEqual(true, ps3.Get("bleach"));
            Assert.AreEqual(false, ps3.Get("forest"));
        }


        [TestMethod]
        public void TestEDifference_1()
        {
            PowerSet<string> ps1 = new PowerSet<string>();
            PowerSet<string> ps2 = new PowerSet<string>();

            ps1.Put("j1");
            ps1.Put("j2");
            ps1.Put("car");
            ps1.Put("far");

            ps2.Put("Pop");
            ps2.Put("far");
            ps2.Put("j2");
            ps2.Put("trust");
            ps2.Put("bleach");
            
            PowerSet<string> ps3 = ps1.Difference(ps2);

            Assert.AreEqual(2, ps3.count);

            Assert.AreEqual(true, ps3.Get("car"));
            Assert.AreEqual(true, ps3.Get("j1"));
        }


        [TestMethod]
        public void TestEIsSubset_1()
        {
            PowerSet<string> ps1 = new PowerSet<string>();
            PowerSet<string> ps2 = new PowerSet<string>();

            ps1.Put("j1");
            ps1.Put("j2");
            ps1.Put("car");
            ps1.Put("trust");
            ps1.Put("check");
            ps1.Put("bleach");
            ps1.Put("far1");
            ps1.Put("Pop");
            ps1.Put("far");

            ps2.Put("Pop");
            ps2.Put("far");
            ps2.Put("j2");
            ps2.Put("trust");
            ps2.Put("bleach");
            

            Assert.AreEqual(true, ps1.IsSubset(ps2));
        }


        [TestMethod]
        public void TestEIsSubset_2()
        {
            PowerSet<string> ps1 = new PowerSet<string>();
            PowerSet<string> ps2 = new PowerSet<string>();

            ps1.Put("j1");
            ps1.Put("j2");
            ps1.Put("car");
            ps1.Put("check");
            ps1.Put("bleach");
            ps1.Put("far1");
            ps1.Put("Pop");

            ps2.Put("Pop");
            ps2.Put("far");
            ps2.Put("j2");
            ps2.Put("trust");
            ps2.Put("bleach");
            
            Assert.AreEqual(false, ps1.IsSubset(ps2));
        }


        [TestMethod]
        public void TestPut_Int_1()
        {
            PowerSet<int> ps1 = new PowerSet<int>();

            ps1.Put(1);
            ps1.Put(2);
            ps1.Put(3);
            ps1.Put(6);
            
            Assert.AreEqual(4, ps1.Size());

            Assert.AreEqual(true, ps1.Get(1));
            Assert.AreEqual(true, ps1.Get(2));
            Assert.AreEqual(true, ps1.Get(3));
            Assert.AreEqual(true, ps1.Get(6));
            Assert.AreEqual(false, ps1.Get(5));

            ps1.Put(5);

            Assert.AreEqual(5, ps1.Size());

            Assert.AreEqual(true, ps1.Get(5));
        }


        [TestMethod]
        public void TestPut_Float_1()
        {
            PowerSet<float> ps1 = new PowerSet<float>();

            ps1.Put(1.0f);
            ps1.Put(2.2f);
            ps1.Put(3.01f);
            ps1.Put(6.42f);

            Assert.AreEqual(4, ps1.Size());

            Assert.AreEqual(true, ps1.Get(1));
            Assert.AreEqual(true, ps1.Get(2.2f));
            Assert.AreEqual(true, ps1.Get(3.01f));
            Assert.AreEqual(true, ps1.Get(6.42f));
            Assert.AreEqual(false, ps1.Get(6.43f));

            ps1.Put(6.43f);

            Assert.AreEqual(5, ps1.Size());

            Assert.AreEqual(true, ps1.Get(6.43f));
        }


        [TestMethod]
        public void TestPut_Char_1()
        {
            PowerSet<char> ps1 = new PowerSet<char>();

            ps1.Put('4');
            ps1.Put('o');
            ps1.Put('p');
            ps1.Put('b');

            Assert.AreEqual(4, ps1.Size());

            Assert.AreEqual(true, ps1.Get('4'));
            Assert.AreEqual(true, ps1.Get('o'));
            Assert.AreEqual(true, ps1.Get('p'));
            Assert.AreEqual(true, ps1.Get('b'));
            Assert.AreEqual(false, ps1.Get('k'));
            
            ps1.Put('k');

            Assert.AreEqual(5, ps1.Size());
            Assert.AreEqual(true, ps1.Get('k'));
        }


        [TestMethod]
        public void TestPut_String_1()
        {
            PowerSet<string> ps1 = new PowerSet<string>();

            ps1.Put("bullet");
            ps1.Put("scarlet");
            ps1.Put("parrot");
            ps1.Put("Pop");
            ps1.Put("soap");

            Assert.AreEqual(5, ps1.Size());

            Assert.AreEqual(true, ps1.Get("bullet"));
            Assert.AreEqual(true, ps1.Get("scarlet"));
            Assert.AreEqual(true, ps1.Get("parrot"));
            Assert.AreEqual(true, ps1.Get("soap"));
            Assert.AreEqual(true, ps1.Get("Pop"));
            Assert.AreEqual(false, ps1.Get("pop"));
            Assert.AreEqual(false, ps1.Get("quatro"));

            ps1.Put("quatro");

            Assert.AreEqual(6, ps1.Size());
            Assert.AreEqual(true, ps1.Get("quatro"));
        }


        [TestMethod]
        public void TestPut_Node_1()
        {
            PowerSet<Node> ps1 = new PowerSet<Node>();

            Node node1 = new Node();
            Node node2 = new Node();
            Node node3 = new Node();
            Node node4 = new Node();
            Node node5 = new Node();

            ps1.Put(node1);
            ps1.Put(node2);
            ps1.Put(node3);
            ps1.Put(node4);

            Assert.AreEqual(4, ps1.Size());

            Assert.AreEqual(true, ps1.Get(node1));
            Assert.AreEqual(true, ps1.Get(node2));
            Assert.AreEqual(true, ps1.Get(node3));
            Assert.AreEqual(true, ps1.Get(node4));
            Assert.AreEqual(false, ps1.Get(node5));

            ps1.Put(node5);

            Assert.AreEqual(5, ps1.Size());
            Assert.AreEqual(true, ps1.Get(node5));
        }
    }
}
