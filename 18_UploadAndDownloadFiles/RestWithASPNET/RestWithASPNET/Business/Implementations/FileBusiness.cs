﻿using Microsoft.AspNetCore.Http;
using RestWithASPNET.Data.VO;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace RestWithASPNET.Business.Implementations
{
    public class FileBusiness : IFileBusiness
    {
        private readonly string _basePath;
        private readonly IHttpContextAccessor _context;

        public FileBusiness(IHttpContextAccessor context)
        {
            _context = context;
            _basePath = Directory.GetCurrentDirectory() + "\\UploadDir\\";
        }

        public byte[] GetFile(string filename)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<FileDetailVO>> SaveFilesToDisk(IList<IFormFile> file)
        {
            throw new System.NotImplementedException();
        }

        public Task<FileDetailVO> SaveFileToDisk(IFormFile file)
        {
            throw new System.NotImplementedException();
        }
    }
}
