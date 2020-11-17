using System;
using System.Collections.Generic;

public static partial class Algorithms{
    static int Partition(List<Range> arr, int left, int right, Range pivot){
        while (left <= right)
        {
            while (arr[left] < pivot)
            {
                left++;
            }

            while (arr[right] > pivot)
            {
                right--;
            }

            if (left <= right)
            {
                Range tmp = arr[left];
                arr[left] = arr[right];
                arr[right] = tmp;

                left++;
                right--;
            }
        }

        return left;
    }

    static void QuickSort(List<Range> arr, int left, int right)
    {
        if (left >= right)
        {
            return;
        }

        int randomIndex = new Random().Next(left, right);
        Range pivot = arr[randomIndex];
        int partition = Partition(arr, left, right, pivot);

        QuickSort(arr, left, partition - 1);
        QuickSort(arr, partition, right);
    }

    //simulates a task
    public class Range : IComparable<Range>
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

        public int CompareTo(Range r)
        {
            if (this.end > r.end)
            {
                return 1;
            }
            else if (this.end < r.end)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public static bool operator >(Range r1, Range r2)
        {
            if(r1.CompareTo(r2) == 1)
            {
                return true;
            }

            return false;
        }

        public static bool operator <(Range r1, Range r2)
        {
            return r2 > r1;
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
            QuickSort(activities, 0, activities.Count - 1);

            activities.Reverse();
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



