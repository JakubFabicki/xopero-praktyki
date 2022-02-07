using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ul
{
    class Worker : Bee
    {
        public string CurrentJob;
        public int ShiftLeft;

        private string[] jobsICanDo;

        public Worker(string[] task, double weightMg) : base(weightMg)
        {
            jobsICanDo = task;
        }

        public bool DoThisJob(string nextJob, int shiftLeft)
        {
            if(String.IsNullOrEmpty(CurrentJob))
            {
                for (int i = 0; i < jobsICanDo.Length; i++)
                    if (jobsICanDo[i] == nextJob)
                    {
                        CurrentJob = nextJob;
                        ShiftLeft = shiftLeft;
                        return true;
                    }
                return false;
            }
            else
                return false;
        }

        private int ShiftWorked;

        public void WorkOneShift()
        {
            ShiftLeft--;
            ShiftWorked++;
            if (ShiftLeft == 0)
            {
                CurrentJob = null;
                ShiftWorked = 0;
            }
        }

        const double honeyUnitsPerShiftWorked = .65;

        public override double HoneyConsumptionRate()
        {
            double consumption = base.HoneyConsumptionRate();
            consumption += ShiftWorked * honeyUnitsPerShiftWorked;
            return consumption;
        }
    }
}
