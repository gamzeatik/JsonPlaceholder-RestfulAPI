﻿using RestfulAPI.Model;

namespace RestfulAPI.Service
{
    public interface IAlbumService
    {
        Album Create(Album album);
        Album GetById(int id);
        Album Update(int id, Album album);
        List<Album> GetAll();
        void Delete(int id);

    }
}
