using Dtos.ClientDto;

namespace ClientTest
{
    public class GetClientTest
    {
        [Test]
        public async Task GetAllClients_ShouldExcludeSoftDeletedClients()
        {
            // Arrange
            var clients = new List<Client>
     {
        new ClientDto { Id = 1, Name = "Diego", Dni = 20304050, SoftDeleted = false },
        new ClientDto { Id = 2, Name = "Lionel", Dni = 40708090, SoftDeleted = true }
         };

            _contextMock.Setup(c => c.Clients.ToListAsync())
                .ReturnsAsync(clients);

            _mapperMock.Setup(m => m.Map<List<ClientDto>>(It.IsAny<List<Client>>()))
                .Returns((List<Client> c) => c.Where(client => !client.SoftDeleted).Select(client => new ClientDto { Id = client.Id }).ToList());

            // Act
            var result = await _repository.GetAllClients();

            // Assert
            Assert.That(result.Count, Is.EqualTo(1));
            Assert.That(result[0].Id, Is.EqualTo(1));
        }

    }
}
