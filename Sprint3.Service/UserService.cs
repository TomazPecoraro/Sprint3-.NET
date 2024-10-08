﻿using global::Sprint3.Models.Models;
using global::Sprint3.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

    namespace Sprint3.Service
    {
        public class UserService : IUserService
        {
            private readonly IRepository<User> _userRepository;

            public UserService(IRepository<User> userRepository)
            {
                _userRepository = userRepository;
            }

            public IEnumerable<User> GetAllUsers()
            {
                return _userRepository.GetAll();
            }

            public User GetUserById(int id)
            {
                return _userRepository.GetById(id);
            }

            public void AddUser(User user)
            {
                _userRepository.Add(user);
            }

            public void UpdateUser(User user)
            {
                _userRepository.Update(user);
            }

            public void DeleteUser(int id)
            {
                var user = _userRepository.GetById(id);
                if (user != null)
                {
                    _userRepository.Delete(user);
                }
            }
        }
    }

