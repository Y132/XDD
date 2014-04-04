using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD;

namespace TestProject
{
    /// <summary>
    /// Сводное описание для TestNotebook
    /// </summary>
    [TestClass]
    public class TestNotebook
    {
        public TestNotebook()
        {
            //
            // TODO: добавьте здесь логику конструктора
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Дополнительные атрибуты тестирования
        //
        // При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        // ClassInitialize используется для выполнения кода до запуска первого теста в классе
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // TestInitialize используется для выполнения кода перед запуском каждого теста 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // TestCleanup используется для выполнения кода после завершения каждого теста
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            Note note = new Note("Первая запись");
            Assert.AreEqual(note.get_data(),"Первая запись");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Note note = new Note("Первая запись");
            Assert.AreEqual(note.get_data(), "Первая запись");
            Assert.AreEqual(note.get_time(), DateTime.Now);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Note note = new Note("Первая запись");
            note.set_data("Первая запись");
            Assert.AreEqual(note.get_data(), "Первая запись");
        }

        [TestMethod]
        public void TestMethod4()
        {
            Note note = new Note("Первая запись");
            note.set_data("Вторая запись");
            Assert.AreEqual(note.get_data(), "Вторая запись");
        }

        [TestMethod]
        public void TestMethod5()
        {
                DateTime d = new DateTime(2014,1,1);
            Note note = new Task(d,"Запись");
            Assert.AreEqual(((Task)note).get_dataStart(), d);            
            Assert.AreEqual(((Task)note).get_data(), "Запись");
        }

        [TestMethod]
        public void TestMethod6()
        {
            DateTime d = new DateTime(2014, 2, 2);
            Note note = new Task(d, "Задача");
            Assert.AreEqual(((Task)note).get_dataStart(), d);
            Assert.AreEqual(((Task)note).get_data(), "Задача");
        }


        [TestMethod]
        public void TestMethod7()
        {
            DateTime d = new DateTime(2014, 2, 2);
            Note note = new Task(d, "Задача");
            DateTime d1 = new DateTime(2014, 3, 3);
            ((Task)note).set_dataStart(d1);
            Assert.AreEqual(((Task)note).get_dataStart(), d1);
            Assert.AreEqual(((Task)note).get_data(), "Задача");
        }

        [TestMethod]
        public void TestMethod8()
        {
            DateTime d = new DateTime(2014, 2, 2);
            Note note = new Task(d, "Задача");
            DateTime d1 = new DateTime(2014, 12, 12);
            ((Task)note).set_dataStart(d1);
            Assert.AreEqual(((Task)note).get_dataStart(), d1);
            Assert.AreEqual(((Task)note).get_data(), "Задача");
        }

        [TestMethod]
        public void TestMethod9()
        {
            Note note = new Contact("ФИО","Задача");
            Assert.AreEqual(((Contact)note).get_fio(), "ФИО");
        }

        [TestMethod]
        public void TestMethod10()
        {
            Note note = new Contact("Петров Петр Петрович", "Задача");
            Assert.AreEqual(((Contact)note).get_fio(), "Петров Петр Петрович");
        }

        [TestMethod]
        public void TestMethod11()
        {
            Note note = new Contact("Петров Петр Петрович", "Задача");
            ((Contact)note).set_fio("Иванов");
            Assert.AreEqual(((Contact)note).get_fio(), "Иванов");
        }

        [TestMethod]
        public void TestMethod12()
        {
            Note note = new Contact("Петров Петр Петрович", "Задача");
            ((Contact)note).set_fio("Антонов");
            Assert.AreEqual(((Contact)note).get_fio(), "Антонов");
        }

        [TestMethod]
        public void TestMethod13()
        {
            Note note = new Contact("ФИО", "Адрес", "Телефон", "Задача");
            Assert.AreEqual(((Contact)note).get_adress(), "Адрес");
            Assert.AreEqual(((Contact)note).get_tel(), "Телефон");
        }

        [TestMethod]
        public void TestMethod14()
        {
            Note note = new Contact("ФИО", "Барнаул", "11-22", "Задача");
            Assert.AreEqual(((Contact)note).get_adress(), "Барнаул");
            Assert.AreEqual(((Contact)note).get_tel(), "11-22");
        }
    }
}
