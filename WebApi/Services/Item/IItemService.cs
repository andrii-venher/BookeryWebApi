﻿using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace WebApi.Services.Item
{
    public interface IItemService
    {
        Task<IEnumerable<Domain.Models.Item>> GetSubItems(string path);
        Task<Domain.Models.Item> CreateDirectory(string path);
        Task<Domain.Models.Item> UploadFile(string path, string name, Stream content);
        Task<Stream> DownloadFile(string path);
    }
}