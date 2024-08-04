using Microsoft.VisualStudio.TestTools.UnitTesting;
using InventoryManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Tests
{
    [TestClass()]
    public class OrderModuleFormTests
    {
        [TestMethod]
        public void TestInsertOrder()
        {
            var form = new OrderModuleForm();
            form.txtCId.Text = "1";
            form.txtPid.Text = "1";
            form.txtPrice.Text = "10";
            form.UDQty.Value = 5;
            form.btnInsert_Click(null, EventArgs.Empty);
            Assert.Equals(45, form.UDQty);
        }
        [TestMethod]
        public void TestClear()
        {
            var form = new OrderModuleForm();
            form.txtCId.Text = "1";
            form.txtCName.Text = "TestCustomer";
            form.txtPid.Text = "1";
            form.txtPName.Text = "TestProduct";
            form.txtPrice.Text = "10";
            form.UDQty.Value = 2;
            form.txtTotal.Text = "20";
            form.Clear();
            Assert.AreEqual("", form.txtCId.Text, "Failed to clear Customer ID field.");
            Assert.AreEqual("", form.txtCName.Text, "Failed to clear Customer Name field.");
        }
    }
}