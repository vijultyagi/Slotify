using MediatR;
using Slotify.Domain.Interfaces;

namespace Slotify.Application.Commands.DeleteService;

public class DeleteServiceHandler(IServiceRepository _serviceRepository) : IRequestHandler<DeleteServiceCommand, Guid>
{
    public async Task<Guid> Handle(DeleteServiceCommand command, CancellationToken cancellationToken)
    {
        return await _serviceRepository.DeleteServiceAsync(command.Id);
    }
}
