﻿using System;
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
    }
}