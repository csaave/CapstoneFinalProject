//using fitness_capstone_4.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace fitness_capstone_4.Data
//{
//    public class EntriesRepository
//    {

//        public List<Entry> GetEntries()
//        {
//            return Data.Entries
//                .Join(
//                    Data.Activities, 
//                    e => e.ActivityId, 
//                    a => a.Id,  
//                    (e, a) =>  
//                    {
//                        e.Workouts = a; 
//                        return e; 
//                    }
//                    )
//                .OrderByDescending(e => e.Date)
//                .ThenByDescending(e => e.Id)
//                .ToList();
//        }


//        public Entry GetEntry(int id)
//        {
//            Entry entry = Data.Entries
//                .Where(e => e.Id == id)
//                .SingleOrDefault();

//            if (entry.Workouts == null)
//            {
//                entry.Workouts = Data.Activities
//                    .Where(a => a.Id == entry.ActivityId)
//                    .SingleOrDefault();
//            }

//            return entry;
//        }
//        public void AddEntry(Entry entry)
//        {

//            int nextAvailableEntryId = Data.Entries
//                .Max(e => e.Id) + 1;

//            entry.Id = nextAvailableEntryId;

//            Data.Entries.Add(entry);
//        }
//        public void UpdateEntry(Entry entry)
//        {
//            int entryIndex = Data.Entries.FindIndex(e => e.Id == entry.Id);

//            if (entryIndex == -1)
//            {
//                throw new Exception(
//                    string.Format("Unable to find an entry with an ID of {0}", entry.Id));
//            }

//            Data.Entries[entryIndex] = entry;
//        }
//        public void DeleteEntry(int id)
//        {

//            int entryIndex = Data.Entries.FindIndex(e => e.Id == id);

//            if (entryIndex == -1)
//            {
//                throw new Exception(
//                    string.Format("Unable to find an entry with an ID of {0}", id));
//            }

//            Data.Entries.RemoveAt(entryIndex);
//        }
//    }
//}