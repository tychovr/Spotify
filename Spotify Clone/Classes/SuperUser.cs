﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify_Clone
{
    internal class SuperUser : Person
    {
        private List<Album> allAlbums = new List<Album>();
        private List<Song> allSongs = new List<Song>();
        private List<Person> allUsers = new List<Person>();

        public List<Album> AllAlbums { get => allAlbums; set => allAlbums = value; }
        public List<Song> AllSongs { get => allSongs; set => allSongs = value; }
        public List<Person> AllUsers { get => allUsers; set => allUsers = value; }

        public SuperUser(string name, Person person) : base(name)
        {
        }

        public SuperUser(string name, List<Album> album, List<Song> song, List<Person> person) : base(name)
        {
            AllAlbums = album;
            AllSongs = song;
            AllUsers = person;
        }

        public void AddFriend(Person person)
        {
            Friends.Add(person);
        }

        public void RemoveFriend(Person person)
        {
            Friends.Remove(person);
        }

        public void CreatePlayList(string name)
        {
            Playlist playlist = new Playlist(this, name);
            Playlists.Add(playlist);
        }

        public void RemovePlayList(int id)
        {
            Playlists.RemoveAt(id);
        }

        public void AddToPlayList(IPlayable playable)
        {
            Playlists[0].Add(playable);
        }

        public void RemoveFromPlayList(IPlayable playable)
        {
            Playlists[0].Remove(playable);
        }
    }
}
