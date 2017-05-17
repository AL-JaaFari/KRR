using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Agent
    {
        public string Name;

        public Agent(string name)
        {
            this.Name = name;

        }

        public void PerformAction()
        {
            
        }

    }






    public class Fluent
    {
        public string Name;

        public Fluent(string name)
        {
            this.Name = name;

        }

        public override bool Equals(object obj)
        {
            if (obj is Fluent)
            {
                var fluent = obj as Fluent;
                if (Name.Equals(fluent.Name)) return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {

            return Name;
        }
    }

    public class Action 
    {
        public string Name;

        public Action() { }

        public Action(string name)
        {
            Name = name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Action)
            {
                var action = obj as Action;
                if (action.Name.Equals(this.Name))
                    return true;
            }
            return false;
        }

        public object Clone()
        {
            Action Act = new Action();
            Act.Name = Name;
            return Act;
        }

        public override string ToString()
        {
            return "(" + this.Name + ")";
        }
    }






}
