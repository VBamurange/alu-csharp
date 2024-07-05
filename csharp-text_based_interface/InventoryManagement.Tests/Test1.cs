using System;
using System.Collections.Generic;
using InventoryLibrary;
using Xunit;

namespace InventoryManagement.Tests
{
    public class InventoryTests
    {
        [Fact]
        public void TestCreateUser()
        {
            var user = new User("TestUser");
            Assert.Equal("TestUser", user.Name);
        }

        [Fact]
        public void TestCreateItem()
        {
            var item = new Item("TestItem")
            {
                Description = "TestDescription",
                Price = 10.5f,
                Tags = new List<string> { "TestTag1", "TestTag2" }
            };

            Assert.Equal("TestItem", item.Name);
            Assert.Equal("TestDescription", item.Description);
            Assert.Equal(10.5f, item.Price);
            Assert.Contains("TestTag1", item.Tags);
            Assert.Contains("TestTag2", item.Tags);
        }

        [Fact]
        public void TestCreateInventory()
        {
            var inventory = new Inventory("UserId1", "ItemId1", 5);
            Assert.Equal("UserId1", inventory.UserId);
            Assert.Equal("ItemId1", inventory.ItemId);
            Assert.Equal(5, inventory.Quantity);
        }

        [Fact]
        public void TestInvalidItemPrice()
        {
            var item = new Item("TestItem");
            Assert.Throws<FormatException>(() => { item.Price = float.Parse("InvalidPrice"); });
        }

        [Fact]
        public void TestInvalidInventoryQuantity()
        {
            Assert.Throws<ArgumentException>(() => new Inventory("UserId1", "ItemId1", -1));
        }
    }
}
