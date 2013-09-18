﻿using MessageBoardTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MessageBoardTutorial.Controllers
{
    public class PostsController : ApiController
    {
        private MessageBoardContext _ctx;
        public PostsController()
        {
            this._ctx = new MessageBoardContext();
        }

        // GET api/<controller>
        public IEnumerable<object> Get()
        {
            return this._ctx.Posts.OrderByDescending(x => x.DatePosted).ToList();
        }
    }
}