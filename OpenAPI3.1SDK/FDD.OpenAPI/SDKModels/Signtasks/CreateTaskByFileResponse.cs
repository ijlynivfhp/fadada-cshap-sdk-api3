﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDD.OpenAPI.SDKModels.Signtasks
{
    public class CreateTaskByFileResponse
    {
        public string taskId { get; set; }
        public List<SignFileIds> signFileIds { get; set; }
        public class SignFileIds
        {
            public string signFileId { get; set; }
            public string fileId { get; set; }
            public string signFileName { get; set; }
        }
    }
}
