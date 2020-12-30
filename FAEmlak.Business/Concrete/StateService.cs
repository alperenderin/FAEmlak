using System;
using System.Collections.Generic;
using FAEmlak.Business.Abstract;
using FAEmlak.Data.Abstract;
using FAEmlak.Entity;

namespace FAEmlak.Business.Concrete
{
    public class StateService : IStateService
    {
        private readonly IUnitOfWork _unitOfWork;
        public StateService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(State entity)
        {
            _unitOfWork.States.Create(entity);
        }

        public void Delete(State entity)
        {
            _unitOfWork.States.Delete(entity);
        }

        public State GetById(int id)
        {
            return _unitOfWork.States.GetById(id);
        }

        public List<State> GetStates()
        {
            return _unitOfWork.States.GetStates();
        }

        public void Update(State entity)
        {
            _unitOfWork.States.Update(entity);
        }
    }
}
