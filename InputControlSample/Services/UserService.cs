using InputControlSample.Data.Models;
using InputControlSample.Repositories;
using System.Collections.Generic;

namespace InputControlSample.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void Add(User entity)
        {
            _userRepository.Add(entity);
        }

        public User Get(int id)
        {
            return _userRepository.Get(id);
        }
        public User Get(string id)
        {
            return _userRepository.Get(id);
        }

        /// <summary>
        /// ユーザーデータを全件取得
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        public void Remove(int id)
        {
            _userRepository.Remove(id);
        }

        public void Update(User entity, int id)
        {
            _userRepository.Update(entity, id);
        }

    }
}
