// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using System.Linq;
// using System.Threading.Tasks;
// using Xunit;

// public class UsersControllerTests
// {
//     private DbContextOptions<ApplicationDbContext> _options;

//     public UsersControllerTests()
//     {
//         // Set up in-memory database
//         _options = new DbContextOptionsBuilder<ApplicationDbContext>()
//             .UseInMemoryDatabase(databaseName: "TestDatabase")
//             .Options;
//     }

//     [Fact]
//     public async Task PutUser_ValidId_UpdatesUser()
//     {
//         // Arrange
//         using (var context = new ApplicationDbContext(_options))
//         {
//             var user = new User { Id = 1, Name = "John", Email = "john@example.com" };
//             context.Users.Add(user);
//             await context.SaveChangesAsync();
//         }

//         // Act
//         using (var context = new ApplicationDbContext(_options))
//         {
//             var controller = new UsersController(context);
//             var updatedUser = new User { Id = 1, Name = "John Updated", Email = "john.updated@example.com" };

//             var result = await controller.PutUser(1, updatedUser);

//             // Assert
//             Assert.IsType<NoContentResult>(result);

//             var userFromDb = context.Users.SingleOrDefault(u => u.Id == 1);
//             Assert.NotNull(userFromDb);
//             Assert.Equal("John Updated", userFromDb.Name);
//             Assert.Equal("john.updated@example.com", userFromDb.Email);
//         }
//     }
// }