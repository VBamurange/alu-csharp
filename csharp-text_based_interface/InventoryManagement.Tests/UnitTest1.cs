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
            Assert.Equal("TestUser", user.name);
        }

        [Fact]
        public void TestCreateItem()
        {
            var item = new Item("TestItem")
            {
                description = "TestDescription",
                Price = 10.5f,
                tags = new List<string> { "TestTag1", "TestTag2" }
            };

            Assert.Equal("TestItem", item.iName);
            Assert.Equal("TestDescription", item.description);
            Assert.Equal(10.5f, item.Price);
            Assert.Contains("TestTag1", item.tags);
            Assert.Contains("TestTag2", item.tags);
        }

        [Fact]
        public void TestCreateInventory()
        {
            var inventory = new Inventory("UserId1", "ItemId1", 5);
            Assert.Equal("UserId1", inventory.user_id);
            Assert.Equal("ItemId1", inventory.item_id);
            Assert.Equal(5, inventory.quantity);
        }

        [Fact]
        public void TestInvalidItemPrice()
        {
            var item = new Item("TestItem");
            Assert.Throws<FormatException>(() => { item.Price = float.Parse("InvalidPrice"); });
        }
    }
}
