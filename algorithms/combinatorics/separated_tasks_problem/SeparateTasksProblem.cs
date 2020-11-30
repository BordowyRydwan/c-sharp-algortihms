using System;
using System.Collections.Generic;

public static partial class Algorithms{
    public class Range
    {
        public readonly int start;
        public readonly int end;

        public int Length {
            get
            {
                return end - start + 1;
            }
        }

        public Range(int start, int end)
        {
            if (end < start)
            {
                this.end = start;
                this.start = end;
            }
            else
            {
                this.start = start;
                this.end = end;
            }
        }

        public static bool IsNumberInRange(int num, Range range)
        {
            if(range != null)
            {
                return num >= range.start && num < range.end;
            }

            return false;
        }

        public override string ToString()
        {
            return "(" + start + ", " + end + ")";
        }
    }

    //initialized by a list of Range()
    public class Schedule
    {
        List<Range> activities;
        int hourMin;
        int hourMax;

        public Schedule(List<Range> activities)
        {
            this.activities = activities;
            this.hourMin = this.ScheduleScopes.start;
            this.hourMax = this.ScheduleScopes.end;
        }

        private Range ScheduleScopes
        {
            get
            {
                int min = activities[0].start;
                int max = activities[0].end;

                foreach (Range activity in activities)
                {
                    if(activity.start < min)
                    {
                        min = activity.start;
                    }

                    if (activity.end > max)
                    {
                        max = activity.end;
                    }
                }

                return new Range(min, max);
            }
        }

        public int Length
        {
            get
            {
                return hourMax - hourMin + 1;
            }
        }

        public int[] ActivitiesCountByHours
        {
            get
            { 
                int[] resultArray = new int[Length];

                for(int i = 0; i < resultArray.Length; ++i)
                {
                    resultArray[i] = 0;
                }

                foreach(Range activity in activities)
                {
                    for(int i = activity.start; i < activity.end; ++i)
                    {
                        resultArray[i]++;
                    }
                }

                return resultArray;
            }
        }

        public void SortByEndTime()
        {
            activities.Sort((a1, a2) => (a2.end).CompareTo(a1.end));
        }

        public void ClearNotSeparateActivities() //wlasciwy algorytm
        {
            int[] activitiesCounters = this.ActivitiesCountByHours;

            this.SortByEndTime();

            for(int i = 0; i < activitiesCounters.Length; ++i)
            {
                List<int> indexesToDelete = new List<int>();

                if(activitiesCounters[i] > 1)
                {
                    int activitiesToDelete = activitiesCounters[i] - 1;
                    int j = 0;

                    while(activitiesToDelete > 0 && j < activities.Count)
                    {
                        if(Range.IsNumberInRange(i, activities[j]))
                        {
                            indexesToDelete.Add(j);
                            activitiesToDelete--;
                        }

                        j++;
                    }
                }

                for (int j = 0; j < indexesToDelete.Count; ++j)
                {
                    for(int k = activities[indexesToDelete[j]].start; k <= activities[indexesToDelete[j]].end; k++)
                    {
                        activitiesCounters[k]--;
                    }
                }

                for (int j = 0; j < indexesToDelete.Count; ++j)
                {
                    activities[indexesToDelete[j]] = null;
                }
            }

            activities.Reverse();
        }

        public override string ToString()
        {
            string result = "";

            foreach(Range activity in activities)
            {
                if(activity != null)
                {
                    result += activity + "\n";
                }
            }

            return result;
        }
        
    }
}



