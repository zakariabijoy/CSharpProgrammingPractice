﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace MongoDbDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("AddressBook");

            //PersonModel person = new PersonModel()
            //{
            //    FirstName = "a",
            //    LastName = "b",
            //    PrimaryAddress = new AddressModel
            //    {
            //        StreetAddress = "a",
            //        City = "b",
            //        State = "a",
            //        Zipcode = "213"
            //    }

            //};

            //db.InSertRecord("Users", person);

            //var recs = db.LoadRecord<PersonModel>("Users");
            //recs.ForEach(r => Console.WriteLine($"{r.Id}: {r.FirstName} {r.LastName} {r.PrimaryAddress?.City}"));

           var oneRec = db.LoadRecordById<PersonModel>("Users", new Guid("36a7ae3f-9f72-43f9-99c0-539d3dca9ce5"));
            //oneRec.DateOfBirth = new DateTime(1994, 12, 11, 0, 0, 0, DateTimeKind.Utc);
            //db.UpsertRecord("Users", oneRec.Id, oneRec);
            db.DeleteRecord<PersonModel>("Users", oneRec.Id);
           
            Console.ReadLine();
        }


    }

    public class PersonModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public AddressModel PrimaryAddress { get; set; }

        [BsonElement("dob")]
        public DateTime DateOfBirth { get; set; }
    }

    public class AddressModel
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
    }

    public class MongoCRUD
    {
        private IMongoDatabase db;
        public MongoCRUD(string database)
        {
            var client = new MongoClient();
            db = client.GetDatabase(database);
        }

        public void InSertRecord<T>(string table , T recond)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(recond);
        }

        public List<T> LoadRecord<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }

        public T LoadRecordById<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            return collection.Find(filter).First();
        }

        public void UpsertRecord<T>(string table , Guid id, T record)
        {
            var collection = db.GetCollection<T>(table);
            var result = collection.ReplaceOne(new BsonDocument("_id", id), record, new UpdateOptions { IsUpsert = true });
        }

        public void DeleteRecord<T>(string table, Guid id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }
    }
}
