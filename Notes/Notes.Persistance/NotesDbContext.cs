﻿using Microsoft.EntityFrameworkCore;
using Notes.Application.Interfaces;
using Notes.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Persistance
{
    public class NotesDbContext : DbContext, INotesDbContext
    {
        public DbSet<Note> Notes { get ; set ; }
        public NotesDbContext(DbContextOptions<NotesDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
    }
}
