using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioResolvidoSet.Entities
{
    class RegistroLog
    {
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is RegistroLog))
            {
                return false;
            }

            RegistroLog outro = obj as RegistroLog;

            return Username.Equals(outro.Username);

        }

    }
}
