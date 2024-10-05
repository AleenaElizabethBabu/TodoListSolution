using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TodoList.Models;
using Xunit;

namespace TodoList.Tests
{
    public class ToDoItemTests
    {
        [Fact]
        public void CanCreateToDoItem()
        {
            var item = new ToDoItem
            {
                Title = "Test",
                Description = "Test Description",
                CreatedDate = DateTime.Now
            };

            Assert.Equal("Test", item.Title);
            Assert.Equal("Test Description", item.Description);
            Assert.NotNull(item.CreatedDate);
        }

        [Fact]
        public void CanMarkItemAsComplete()
        {
            var item = new ToDoItem
            {
                Title = "Test",
                Description = "Test Description",
                CreatedDate = DateTime.Now
            };

            item.CompletedDate = DateTime.Now;
            Assert.NotNull(item.CompletedDate);
        }

        [Fact]
        public void CanGetItemById()
        {
            var item = new ToDoItem { Id = 1, Title = "Test" };
            Assert.Equal(1, item.Id);
        }

        [Fact]
        public void CanCreateMultipleItems()
        {
            var item1 = new ToDoItem { Title = "Item 1" };
            var item2 = new ToDoItem { Title = "Item 2" };

            Assert.NotEqual(item1.Title, item2.Title);
        }
    }
}
