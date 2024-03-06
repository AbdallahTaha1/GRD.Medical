using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MedicalInfos.Commands.UpdateMedicalInfo
{
    public class UpdateMedicalInfoCommandHandler : IRequestHandler<UpdateMedicalInfoCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly ICurrentUser _currentUser;
        public UpdateMedicalInfoCommandHandler(IApplicationDbContext context, ICurrentUser currentUser)
        {
            _context = context;
            _currentUser = currentUser;
        }
        public async Task<Unit> Handle(UpdateMedicalInfoCommand request, CancellationToken cancellationToken)
        {
            var medicalInfo = await _context.MedicalInfos.FirstOrDefaultAsync(u => u.UserId == _currentUser.Id);

            if (medicalInfo == null)
            {
                CreateMedicalInfo(request);
                await _context.SaveChangesAsync();
                return Unit.Value;
            }

            UpdateMedicalInfo(request, medicalInfo);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
        private void CreateMedicalInfo(UpdateMedicalInfoCommand request)
        {
            var medicalInfo = new MedicalInfo
            {
                Age = request.Age,
                Hight = request.Hight,
                Wight = request.Wight,
                Diabetic = request.Diabetic,
                Hypertension = request.Hypertension,
                Hypotension = request.Hypotension,
                Smoker = request.Smoker,
                UserId = _currentUser.Id
            };
            medicalInfo.AddDomainEvent(new EntityCreatedEvent(medicalInfo));
            _context.MedicalInfos.Add(medicalInfo);
        }
        private void UpdateMedicalInfo(UpdateMedicalInfoCommand request, MedicalInfo medicalInfo)
        {
            if(request.Age != null) medicalInfo.Age = request.Age;
            if (request.Hight != null) medicalInfo.Hight = request.Hight;
            if (request.Wight != null) medicalInfo.Wight = request.Wight;
            if (request.Diabetic != null) medicalInfo.Diabetic = request.Diabetic;
            if (request.Hypertension != null) medicalInfo.Hypertension = request.Hypertension;
            if (request.Hypotension != null) medicalInfo.Hypotension = request.Hypotension;
            if (request.Smoker != null) medicalInfo.Smoker = request.Smoker;

            medicalInfo.AddDomainEvent(new EntityUpdatedEvent(medicalInfo));
        }
    }
}
