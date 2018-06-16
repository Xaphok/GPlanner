﻿// Base class by Xaphok

using System;
using System.Collections.Generic;
using System.Text;

namespace GPlanner.Classes
{
    /// <summary>
    /// A task is something that the user has to do. Tasks are displayed in "ToDoListPage".
    /// </summary>
    class TaskToDo //The name "Task" is already taken by System.Threading.Tasks
    {
        // ========== ATTRIBUTES ==========

            //REQUIRED
        public string _name { get; private set; }

            //OPTIONAL
        public Orientation _orientation { get; private set; } // work, hobbies , ?
        public Importance _importance { get; private set; } //the higher the value, the higher the importance
        public string _place { get; private set; }
        public Date _deadline { get; private set; }
        public Date _plannedFor { get; private set; }
        public byte _percentageCompleted { get; private set; }
        // public ? _repeat { get; private set; } // Repeat this task every day/week/month...

        // ========== CONSTRUCTORS ==========
        public TaskToDo(string name, Importance importance = Importance.NORMAL, string place = "", byte percentageCompleted = 0 )
        {
            _name = name;
            _importance = importance;
            _place = place;
            _percentageCompleted = percentageCompleted;
            
           // _deadline = deadline;
           // _plannedFor = plannedFor;
           // _repeat = repeat;
              
        }
        // ========== METHODS ==========



        // ========== ENUMS ==========
        public enum Orientation { WORK, HOBBY, NONE } //others ?
        public enum Importance { LOW, NORMAL, HIGH}
    }
}