using System;
using System.Collections.Generic;
using System.Text;

namespace Universe
{
    class UniverseCell
    {
        private bool isActive;

        public UniverseCell()
        {
            isActive = false;
        }

        public void ChangeValue ()
        {
            if (isActive)
            {
                isActive = false;
            }
            else
            {
                isActive = true;
            }
        }

        public bool IsActive
        {
            get { return isActive; }
        }
    }
}
