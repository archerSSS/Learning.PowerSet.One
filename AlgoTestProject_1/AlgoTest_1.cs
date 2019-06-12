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
            Node node1 = new Node(0);
            Node node2 = new Node(1);
            Node node3 = new Node(2);

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
            Assert.AreEqual(false, ps4.Get(new Node(0)));
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

            Assert.AreEqual(5, ps3.count);

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



        // ============================
        // Тесты с разными типами. (int, float, char, string, Node)
        // 1. Добавление и проверка на наличие и количество.
        // 2. Максимальное заполнение, проверка на наличие по мере заполнение 
        //      и итоговая проверка на наличие всех элементов
        // 3. Попытка добавления элементов пустыми значениями.(null, 0)
        // 4. Попытка добавления уже существующего элемента.
        // ============================
        // 
        // 

        // Тест 1
        //
        [TestMethod]
        public void TestPut_Int_1()
        {
            PowerSet<int> ps1 = new PowerSet<int>();

            Assert.AreEqual(0, ps1.Size());

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


        // Тест 2
        //
        [TestMethod]
        public void TestPut_Int_2()
        {
            PowerSet<int> ps1 = new PowerSet<int>();

            for (int i = 1; i <= 20000; i++)
            {
                Assert.AreEqual(false, ps1.Get(i));
                ps1.Put(i);
                Assert.AreEqual(true, ps1.Get(i));
            }

            Assert.AreEqual(20000, ps1.Size());

            for (int i = 1; i <= 20000; i++)
                Assert.AreEqual(true, ps1.Get(i));
        }


        // Тест 3
        //
        [TestMethod]
        public void TestPut_Int_3()
        {
            PowerSet<int> ps1 = new PowerSet<int>();

            ps1.Put(0);
            Assert.AreEqual(0, ps1.Size());
            Assert.AreEqual(true, ps1.Get(0));

            ps1.Put(1);
            Assert.AreEqual(1, ps1.Size());
            Assert.AreEqual(true, ps1.Get(1));

            ps1.Put(0);
            Assert.AreEqual(1, ps1.Size());
            Assert.AreEqual(true, ps1.Get(1));
        }


        // Тест 4
        //
        [TestMethod]
        public void TestPut_Int_4()
        {
            PowerSet<int> ps1 = new PowerSet<int>();

            ps1.Put(3);
            ps1.Put(32);
            ps1.Put(321);
            
            Assert.AreEqual(3, ps1.Size());

            ps1.Put(3);
            ps1.Put(32);

            Assert.AreEqual(3, ps1.Size());
        }


        // Тест 5
        //
        [TestMethod]
        public void TestPut_Int_5()
        {
            PowerSet<int> ps1 = new PowerSet<int>();

            for (int i = 0; i < 20000; i++)
                ps1.Put(i);

            Assert.AreEqual(19999, ps1.Size());
            Assert.AreEqual(true, ps1.Get(1));
        }


        // Тест 1
        //
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


        // Тест 2
        //
        [TestMethod]
        public void TestPut_Float_2()
        {
            PowerSet<float> ps1 = new PowerSet<float>();

            for (float i = 1; i <= 20000.0f; i++)
            {
                Assert.AreEqual(false, ps1.Get(i));
                ps1.Put(i);
                Assert.AreEqual(true, ps1.Get(i));
            }
            
            Assert.AreEqual(20000, ps1.Size());

            for (float i = 1; i <= 20000.0f; i++)
                Assert.AreEqual(true, ps1.Get(i));
        }


        // Тест 3
        //
        [TestMethod]
        public void TestPut_Float_3()
        {
            PowerSet<float> ps1 = new PowerSet<float>();

            ps1.Put(0.0f);
            Assert.AreEqual(0, ps1.Size());
            Assert.AreEqual(true, ps1.Get(0.0f));

            ps1.Put(1.1f);
            Assert.AreEqual(1, ps1.Size());
            Assert.AreEqual(true, ps1.Get(1.1f));

            ps1.Put(0);
            Assert.AreEqual(1, ps1.Size());
            Assert.AreEqual(true, ps1.Get(1.1f));
        }


        // Тест 4
        //
        [TestMethod]
        public void TestPut_Float_4()
        {
            PowerSet<float> ps1 = new PowerSet<float>();

            ps1.Put(0.3f);
            ps1.Put(3.2f);
            ps1.Put(32.1f);

            Assert.AreEqual(3, ps1.Size());

            ps1.Put(3.2f);
            ps1.Put(32.1f);

            Assert.AreEqual(3, ps1.Size());
        }


        // Тест 1
        //
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


        // Тест 2
        //
        [TestMethod]
        public void TestPut_Char_2()
        {
            PowerSet<char> ps1 = new PowerSet<char>();

            for (int i = 1; i <= 20000; i++)
            {
                Assert.AreEqual(false, ps1.Get(Convert.ToChar(i)));
                ps1.Put(Convert.ToChar(i));
                Assert.AreEqual(true, ps1.Get(Convert.ToChar(i)));
            }
        }


        // Тест 2 Альтернатива
        //
        [TestMethod]
        public void TestPut_Char_2A()
        {
            PowerSet<char> ps1 = new PowerSet<char>();

            for (int i = 1; i <= 20000; i++)
                ps1.Put(Convert.ToChar(i));

            Assert.AreEqual(20000, ps1.Size());

            for (int i = 1; i <= 20000; i++)
                Assert.AreEqual(true, ps1.Get(Convert.ToChar(i)));
        }


        // Тест 3 Альтернатива
        // Добавление пробела в качестве символа
        //
        [TestMethod]
        public void TestPut_Char_3A()
        {
            PowerSet<char> ps1 = new PowerSet<char>();

            ps1.Put(' ');
            Assert.AreEqual(1, ps1.Size());
            Assert.AreEqual(true, ps1.Get(' '));
        }


        // Тест 4
        //
        [TestMethod]
        public void TestPut_Char_4()
        {
            PowerSet<char> ps1 = new PowerSet<char>();

            ps1.Put(' ');
            ps1.Put('5');
            ps1.Put('a');

            Assert.AreEqual(3, ps1.Size());

            ps1.Put('5');
            ps1.Put('a');

            Assert.AreEqual(3, ps1.Size());
        }


        // Тест 1
        //
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


        // Тест 2
        //
        [TestMethod]
        public void TestPut_String_2()
        {
            PowerSet<string> ps1 = new PowerSet<string>();

            for (float i = 1; i <= 20000.0f; i++)
            {
                Assert.AreEqual(false, ps1.Get(""+i));
                ps1.Put(""+i);
                Assert.AreEqual(true, ps1.Get(""+i));
            }

            Assert.AreEqual(20000, ps1.Size());

            for (float i = 1; i <= 20000.0f; i++)
                Assert.AreEqual(true, ps1.Get(""+i));
        }


        // Тест 3
        //
        [TestMethod]
        public void TestPut_String_3()
        {
            PowerSet<string> ps1 = new PowerSet<string>();
            
            Assert.AreEqual(0, ps1.Size());

            ps1.Put("");
            Assert.AreEqual(1, ps1.Size());
            Assert.AreEqual(true, ps1.Get(""));

            ps1.Put(" ");
            Assert.AreEqual(2, ps1.Size());
            Assert.AreEqual(true, ps1.Get(" "));
        }


        // Тест 4
        //
        [TestMethod]
        public void TestPut_String_4()
        {
            PowerSet<string> ps1 = new PowerSet<string>();
            
            ps1.Put("word");
            ps1.Put("string");
            ps1.Put("chars");

            Assert.AreEqual(3, ps1.Size());

            ps1.Put("word");
            ps1.Put("string");

            Assert.AreEqual(3, ps1.Size());
        }


        // Тест 1
        //
        [TestMethod]
        public void TestPut_Node_1()
        {
            PowerSet<Node> ps1 = new PowerSet<Node>();

            Node node1 = new Node(0);
            Node node2 = new Node(1);
            Node node3 = new Node(2);
            Node node4 = new Node(3);
            Node node5 = new Node(4);

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


        // Тест 2 Aльтернатива
        //
        [TestMethod]
        public void TestPut_Node_2()
        {
            PowerSet<Node> ps1 = new PowerSet<Node>();

            for (int i = 0; i < 20000; i++)
                ps1.Put(new Node(i));

            Assert.AreEqual(20000, ps1.Size());
        }
        

        // ============================
        // Тесты с разными типами. (int, char, string, Node)
        // 1. Метод Intersection() при добавлении 5 значений в обоих множествах 
        //      по три одинаковых элемента. Проверка на количество.
        // 2. Максимальное заполнение. 20 одинаковых элемента. Проверка на количество.
        //
        // ============================
        // 
        // 

        // Тест 1
        //
        [TestMethod]
        public void TestIntersection_Int_1()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            PowerSet<int> ps2 = new PowerSet<int>();
            PowerSet<int> ps3;

            for (int i = 1; i <= 5; i++)
                ps1.Put(i);

            for (int i = 3; i <= 7; i++)
                ps2.Put(i);

            ps3 = ps1.Intersection(ps2);

            for (int i = 3; i <= 5; i++)
                Assert.AreEqual(true, ps3.Get(i));

            Assert.AreEqual(3, ps3.Size());
            Assert.AreEqual(false, ps3.Get(6));
            Assert.AreEqual(false, ps3.Get(2));
        }


        // Тест 2
        //
        [TestMethod]
        public void TestIntersection_Int_2()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            PowerSet<int> ps2 = new PowerSet<int>();
            PowerSet<int> ps3;

            for (int i = 1; i <= 20000; i++)
                ps1.Put(i);

            for (int i = 19981; i <= 39980; i++)
                ps2.Put(i);

            ps3 = ps1.Intersection(ps2);

            for (int i = 19981; i <= 20000; i++)
                Assert.AreEqual(true, ps3.Get(i));

            Assert.AreEqual(20, ps3.Size());
            Assert.AreEqual(false, ps3.Get(20005));
            Assert.AreEqual(false, ps3.Get(16050));
        }


        // Тест 3
        //
        [TestMethod]
        public void TestIntersection_Int_3()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            PowerSet<int> ps2 = new PowerSet<int>();
            PowerSet<int> ps3;

            for (int i = 1; i <= 200; i++)
                ps1.Put(i);
            
            ps3 = ps1.Intersection(ps2);
            
            Assert.AreEqual(null, ps3);
        }


        // Тест 2
        //
        [TestMethod]
        public void TestIntersection_Char_1()
        {
            PowerSet<char> ps1 = new PowerSet<char>();
            PowerSet<char> ps2 = new PowerSet<char>();
            PowerSet<char> ps3;

            for (int i = 1; i <= 20000; i++)
                ps1.Put(Convert.ToChar(i));

            for (int i = 19981; i <= 39980; i++)
                ps2.Put(Convert.ToChar(i));

            ps3 = ps1.Intersection(ps2);

            for (int i = 19981; i <= 20000; i++)
                Assert.AreEqual(true, ps3.Get(Convert.ToChar(i)));

            Assert.AreEqual(20, ps3.Size());
            Assert.AreEqual(false, ps3.Get(Convert.ToChar(30382)));
            Assert.AreEqual(false, ps3.Get(Convert.ToChar(10382)));
        }


        // Тест 1
        //
        [TestMethod]
        public void TestIntersection_String_1()
        {
            PowerSet<string> ps1 = new PowerSet<string>();
            PowerSet<string> ps2 = new PowerSet<string>();
            PowerSet<string> ps3;

            for (int i = 1; i <= 5; i++)
                ps1.Put("" + i);

            for (int i = 3; i <= 7; i++)
                ps2.Put("" + i);

            ps3 = ps1.Intersection(ps2);

            for (int i = 3; i <= 5; i++)
                Assert.AreEqual(true, ps3.Get("" + i));

            Assert.AreEqual(3, ps3.Size());
            Assert.AreEqual(false, ps3.Get("1"));
            Assert.AreEqual(false, ps3.Get("33"));
        }


        // Тест 3
        //
        [TestMethod]
        public void TestIntersection_Char_3()
        {
            PowerSet<char> ps1 = new PowerSet<char>();
            PowerSet<char> ps2 = new PowerSet<char>();
            PowerSet<char> ps3;

            for (int i = 1; i <= 200; i++)
                ps1.Put(Convert.ToChar(i));

            ps3 = ps1.Intersection(ps2);

            Assert.AreEqual(null, ps3);
        }


        // Тест 3 Альтернатива
        //
        [TestMethod]
        public void TestIntersection_Char_3A()
        {
            PowerSet<char> ps1 = new PowerSet<char>();
            PowerSet<char> ps2 = new PowerSet<char>();
            PowerSet<char> ps3;

            for (int i = 1; i <= 200; i++)
                ps1.Put(Convert.ToChar(i));

            for (int i = 231; i <= 300; i++)
                ps1.Put(Convert.ToChar(i));

            ps3 = ps1.Intersection(ps2);

            Assert.AreEqual(null, ps3);
        }


        // Тест 2
        //
        [TestMethod]
        public void TestIntersection_String_2()
        {
            PowerSet<string> ps1 = new PowerSet<string>();
            PowerSet<string> ps2 = new PowerSet<string>();
            PowerSet<string> ps3;

            for (int i = 1; i <= 20000; i++)
                ps1.Put(""+i);

            for (int i = 19981; i <= 39980; i++)
                ps2.Put(""+i);

            ps3 = ps1.Intersection(ps2);

            for (int i = 19981; i <= 20000; i++)
                Assert.AreEqual(true, ps3.Get(""+i));

            Assert.AreEqual(20, ps3.Size());
            Assert.AreEqual(false, ps3.Get("f"));
            Assert.AreEqual(false, ps3.Get("222"));
        }


        // Тест 1
        //
        [TestMethod]
        public void TestIntersection_Node_1()
        {
            PowerSet<Node> ps1 = new PowerSet<Node>();
            PowerSet<Node> ps2 = new PowerSet<Node>();
            PowerSet<Node> ps3;
            Node[] nodes = new Node[8];

            for (int i = 1; i < nodes.Length; i++)
                nodes[i] = new Node(i);

            for (int i = 0; i < 5; i++)
                ps1.Put(nodes[i]);

            for (int i = 2; i < 7; i++)
                ps2.Put(nodes[i]);

            ps3 = ps1.Intersection(ps2);

            Assert.AreEqual(3, ps3.Size());

            for (int i = 2; i < 5; i++)
                Assert.AreEqual(true, ps3.Get(nodes[i]));
        }


        // Тест 2
        //
        [TestMethod]
        public void TestIntersection_Node_2()
        {
            PowerSet<Node> ps1 = new PowerSet<Node>();
            PowerSet<Node> ps2 = new PowerSet<Node>();
            PowerSet<Node> ps3;
            Node[] nodes = new Node[39980];

            for (int i = 0; i < nodes.Length; i++)
                nodes[i] = new Node(i);

            for (int i = 0; i < 20000; i++)
                ps1.Put(nodes[i]);

            for (int i = 19980; i < 39980; i++)
                ps2.Put(nodes[i]);

            ps3 = ps1.Intersection(ps2);

            Assert.AreEqual(20, ps3.Size());
            for (int i = 19980; i < 20000; i++)
                Assert.AreEqual(true, ps3.Get(nodes[i]));
        }


        // Тест 1
        //
        [TestMethod]
        public void TestDifference_Int_1()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            PowerSet<int> ps2 = new PowerSet<int>();
            PowerSet<int> ps3;
            
            for (int i = 1; i <= 5; i++)
                ps1.Put(i);

            for (int i = 3; i <= 7; i++)
                ps2.Put(i);

            ps3 = ps1.Difference(ps2);

            Assert.AreEqual(4, ps3.Size());

            for (int i = 1; i <= 7; i++)
            {
                if (i < 3) Assert.AreEqual(true, ps3.Get(i));
                else if (i > 5) Assert.AreEqual(true, ps3.Get(i));
                else Assert.AreEqual(false, ps3.Get(i));
            }
                
        }


        // Тест 2
        //
        [TestMethod]
        public void TestDifference_Int_2()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            PowerSet<int> ps2 = new PowerSet<int>();
            PowerSet<int> ps3;

            for (int i = 1; i <= 10000; i++)
                ps1.Put(i);

            for (int i = 9981; i <= 20000; i++)
                ps2.Put(i);

            ps3 = ps1.Difference(ps2);

            Assert.AreEqual(19980, ps3.Size());

            for (int i = 1; i <= 19980; i++)
                if (i < 9981 || i > 10000) Assert.AreEqual(true, ps3.Get(i));
                else Assert.AreEqual(false, ps3.Get(i));
        }


        // Тест 3 Альтернатива
        //
        [TestMethod]
        public void TestDifference_Int_3A()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            PowerSet<int> ps2 = new PowerSet<int>();
            PowerSet<int> ps3;

            for (int i = 1; i <= 5; i++)
                ps1.Put(i);

            for (int i = 7; i <= 11; i++)
                ps2.Put(i);

            ps3 = ps1.Difference(ps2);

            Assert.AreEqual(10, ps3.Size());

            for (int i = 1; i <= 11; i++)
                if (!(i > 5) && !(i < 7)) Assert.AreEqual(10, ps3.Size());
        }


        // Тест 3
        //
        [TestMethod]
        public void TestDifference_Int_3()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            PowerSet<int> ps2 = new PowerSet<int>();
            PowerSet<int> ps3;

            for (int i = 1; i <= 5; i++)
                ps1.Put(i);

            for (int i = 1; i <= 5; i++)
                ps2.Put(i);

            ps3 = ps1.Difference(ps2);

            Assert.AreEqual(null, ps3);
        }


        // Тест 2
        //
        [TestMethod]
        public void TestUnion_Int_2()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            PowerSet<int> ps2 = new PowerSet<int>();
            PowerSet<int> ps3;

            for (int i = 1; i <= 10000; i++)
                ps1.Put(i);

            for (int i = 9981; i <= 20000; i++)
                ps2.Put(i);

            ps3 = ps1.Union(ps2);

            Assert.AreEqual(20000, ps3.Size());

            for (int i = 1; i <= 20000; i++)
                Assert.AreEqual(true, ps3.Get(i));

        }


        // Тест 3 Альтернатива
        //
        [TestMethod]
        public void TestUnion_Int_3A()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            PowerSet<int> ps2 = new PowerSet<int>();
            PowerSet<int> ps3;

            for (int i = 1; i <= 5; i++)
                ps2.Put(i);

            ps3 = ps1.Union(ps2);

            Assert.AreEqual(5, ps3.Size());

            for (int i = 1; i < 10; i++)
            {
                if (i < 6) Assert.AreEqual(true, ps3.Get(i));
                else Assert.AreEqual(false, ps3.Get(i));
            }
        }


        // Тест 3 Альтернатива
        //
        [TestMethod]
        public void TestUnion_Int_3B()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            PowerSet<int> ps2 = new PowerSet<int>();
            PowerSet<int> ps3;

            for (int i = 1; i <= 5; i++)
                ps1.Put(i);

            ps3 = ps1.Union(ps2);

            Assert.AreEqual(5, ps3.Size());

            for (int i = 1; i < 10; i++)
            {
                if (i < 6) Assert.AreEqual(true, ps3.Get(i));
                else Assert.AreEqual(false, ps3.Get(i));
            }
        }


        // Тест 1
        //
        [TestMethod]
        public void TestIsSubset_Int_1()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            PowerSet<int> ps2 = new PowerSet<int>();

            for (int i = 1; i <= 5000; i++)
                ps1.Put(i);

            for (int i = 1000; i <= 1356; i++)
                ps2.Put(i);

            Assert.AreEqual(true, ps1.IsSubset(ps2));
        }


        // Тест 1 Альтернатива
        //
        [TestMethod]
        public void TestIsSubset_Int_1A()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            PowerSet<int> ps2 = new PowerSet<int>();

            for (int i = 1; i <= 5000; i++)
                ps1.Put(i);

            for (int i = 4000; i <= 5356; i++)
                ps2.Put(i);

            Assert.AreEqual(false, ps1.IsSubset(ps2));
        }


        // Тест 1 Альтернатива
        //
        [TestMethod]
        public void TestIsSubset_Int_1B()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            PowerSet<int> ps2 = new PowerSet<int>();

            for (int i = 1; i <= 5000; i++)
                ps1.Put(i);
            
            Assert.AreEqual(true, ps1.IsSubset(ps2));
        }


        // Тест 2
        //
        [TestMethod]
        public void TestIsSubset_Int_2()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            PowerSet<int> ps2 = new PowerSet<int>();

            for (int i = 1; i <= 20000; i++)
                ps1.Put(i);

            for (int i = 9981; i <= 20000; i++)
                ps2.Put(i);
            
            Assert.AreEqual(true, ps1.IsSubset(ps2));
        }


        // Тест 1
        //
        [TestMethod]
        public void TestIsSubset_String_1()
        {
            PowerSet<string> ps1 = new PowerSet<string>();
            PowerSet<string> ps2 = new PowerSet<string>();

            ps1.Put("Goat");
            ps1.Put("Bear");
            ps1.Put("Raccoon");
            ps1.Put("Bird");
            ps1.Put("Squid");

            ps2.Put("Raccoon");
            ps2.Put("Bird");
            ps2.Put("Squid");
            
            Assert.AreEqual(true, ps1.IsSubset(ps2));
        }


        // Тест 1 Альтернатива
        //
        [TestMethod]
        public void TestIsSubset_String_1A()
        {
            PowerSet<string> ps1 = new PowerSet<string>();
            PowerSet<string> ps2 = new PowerSet<string>();

            ps1.Put("Goat");
            ps1.Put("Bear");
            ps1.Put("Raccoon");
            ps1.Put("Bird");
            ps1.Put("Squid");

            ps2.Put("Raccoon");
            ps2.Put("Bird");
            ps2.Put("Turtle");

            Assert.AreEqual(false, ps1.IsSubset(ps2));
        }


        // Тест 2 Альтернатива
        //
        [TestMethod]
        public void TestIsSubset_String_2B()
        {
            PowerSet<string> ps1 = new PowerSet<string>();
            PowerSet<string> ps2 = new PowerSet<string>();

            for (int i = 1; i <= 5000; i++)
                ps1.Put(""+i);

            for (int i = 1000; i <= 1356; i++)
                ps2.Put(""+i);

            Assert.AreEqual(true, ps1.IsSubset(ps2));
        }


        // Тест 1
        //
        [TestMethod]
        public void TestRemove_Int_1()
        {
            PowerSet<int> ps1 = new PowerSet<int>();
            
            for (int i = 1; i <= 10; i++)
                ps1.Put(i);

            ps1.Remove(1);
            ps1.Remove(2);
            ps1.Remove(0);
            ps1.Remove(0);
            ps1.Remove(0);
            ps1.Remove(0);
            ps1.Remove(0);
            ps1.Remove(0);
            ps1.Remove(0);
            ps1.Remove(0);

            Assert.AreEqual(8, ps1.Size());

            Assert.AreEqual(true, ps1.Get(3));
            Assert.AreEqual(true, ps1.Get(4));
            Assert.AreEqual(true, ps1.Get(0));
            Assert.AreEqual(false, ps1.Get(1));
            Assert.AreEqual(false, ps1.Get(2));
        }


        // Тест 1
        //
        [TestMethod]
        public void TestRemove_String_1()
        {
            PowerSet<string> ps1 = new PowerSet<string>();

            for (int i = 1; i <= 10; i++)
                ps1.Put(""+i);

            ps1.Remove("");
            ps1.Remove(" ");
            ps1.Remove("1");
            ps1.Remove("2");

            Assert.AreEqual(8, ps1.Size());

            Assert.AreEqual(true, ps1.Get("3"));
            Assert.AreEqual(true, ps1.Get("4"));
            Assert.AreEqual(false, ps1.Get("1"));
            Assert.AreEqual(false, ps1.Get("2"));
        }


        // Бит тест
        //
        [TestMethod]
        public void TestBitTest_1()
        {
            PowerSet<string> ps1 = new PowerSet<string>();
            PowerSet<string> ps2 = new PowerSet<string>();

            for (int i = 0; i < 15000; i++)
                ps2.Put("" + i);

            Assert.AreEqual(true, ps2.Get("42"));
            Assert.AreEqual(true, ps2.Get("9281"));
            Assert.AreEqual(true, ps2.Get("618"));
            Assert.AreEqual(15000, ps2.Size());

            for (int i = 5000; i < 10000; i++)
                ps2.Put("" + i);

            Assert.AreEqual(15000, ps2.Size());

            for (int i = 5000; i < 10000; i++)
                ps2.Remove(""+i);

            Assert.AreEqual(10000, ps2.Size());
            Assert.AreEqual(true, ps2.Get("42"));
            Assert.AreEqual(true, ps2.Get("618"));
            Assert.AreEqual(false, ps2.Get("9281"));
            Assert.AreEqual(false, ps2.Get("6814"));

            for (int i = 4000; i < 10000; i++)
                ps2.Put("" + i);

            // 0 -> 15000
            Assert.AreEqual(15000, ps2.Size());
            Assert.AreEqual(true, ps2.Get("6814"));

            for (int i = 8000; i < 16000; i++)
                ps1.Put("" + i);

            PowerSet<string> ps3 = ps1.Intersection(ps2);

            Assert.AreEqual(7000, ps3.Size());
            Assert.AreEqual(true, ps3.Get("8814"));
            Assert.AreEqual(true, ps3.Get("9391"));
            Assert.AreEqual(true, ps3.Get("10425"));
            Assert.AreEqual(true, ps3.Get("12954"));
            Assert.AreEqual(false, ps3.Get("16954"));

            for (int i = 15000; i < 17000; i++)
                ps3.Put("" + i);

            // 8000 -> 16999
            Assert.AreEqual(9000, ps3.Size());       

            Assert.AreEqual(true, ps3.Get("10391"));
            Assert.AreEqual(true, ps3.Get("10425"));
            Assert.AreEqual(true, ps3.Get("16454"));

            // 0 -> 7999; 15000 -> 16999
            PowerSet<string> ps4 = ps3.Difference(ps2);

            Assert.AreEqual(10000, ps4.Size());
            Assert.AreEqual(true, ps4.Get("16325"));
            Assert.AreEqual(true, ps4.Get("16954"));
            Assert.AreEqual(true, ps4.Get("3001"));
            Assert.AreEqual(true, ps4.Get("4128"));
            Assert.AreEqual(false, ps4.Get("17000"));
            Assert.AreEqual(false, ps4.Get("8001"));
            
            PowerSet<string> ps5 = ps1.Union(ps4);

            Assert.AreEqual(17000, ps5.Size());
            Assert.AreEqual(true, ps5.Get("16325"));
            Assert.AreEqual(true, ps5.Get("16954"));
            Assert.AreEqual(true, ps5.Get("3001"));
            Assert.AreEqual(true, ps5.Get("4128"));
            Assert.AreEqual(true, ps5.Get("16999"));
            Assert.AreEqual(true, ps5.Get("8001"));

            Assert.AreEqual(true, ps5.IsSubset(ps1));
            Assert.AreEqual(true, ps5.IsSubset(ps3));
            Assert.AreEqual(false, ps2.IsSubset(ps1));
            Assert.AreEqual(false, ps1.IsSubset(ps3));

            Assert.AreEqual(true, ps5.Remove("7163"));
            Assert.AreEqual(true, ps5.Remove("6929"));
            Assert.AreEqual(true, ps5.Remove("121"));
            Assert.AreEqual(true, ps5.Remove("8234"));
            Assert.AreEqual(false, ps5.Remove("121"));

            Assert.AreEqual(16996, ps5.Size());
            Assert.AreEqual(10000, ps4.Size());
            Assert.AreEqual(9000, ps3.Size());
            Assert.AreEqual(15000, ps2.Size());
            Assert.AreEqual(8000, ps1.Size());
        }
    }
}