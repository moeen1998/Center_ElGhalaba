﻿using Center_ElGhalaba.Models;
using Center_ElGhlaba.Interfaces;
using Center_ElGhlaba.Repositories;
using UserIdentity.Data;

namespace Center_ElGhlaba.Unit_OfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IBaseRepository<Lesson> Lessons { get; private set; }
        public IBaseRepository<Student> Students { get; private set; }
        public IBaseRepository<Teacher> Teachers { get; private set; }
        public IBaseRepository<StudentHistory> History { get; private set; }

        public UnitOfWork(ApplicationDbContext context) 
        {
            _context = context;

            Lessons = new BaseRepository<Lesson>(_context);
            Students = new BaseRepository<Student>(_context);
            Teachers = new BaseRepository<Teacher>(_context);
            History = new BaseRepository<StudentHistory>(_context);

        }

        public UnitOfWork()
        {
        }

        public int Complete() 
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}