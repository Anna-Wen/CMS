﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClassManagementSystem.Models;

namespace ClassManagementSystem.Controllers
{
    [Produces("application/json")]
    [Route("/group")]
    public class GroupController : Controller
    {

        // GET: /group/{groupId}?embedTopics={true|false}&embedGrade={true|false}
        [HttpGet("{groupId}")]
        public IActionResult GetGroupByGroupId(int groupId, [FromQuery]bool embedTopics, [FromQuery]bool embedGrade)
        {
            // Fetch selected data from database
            Student leader = new Student { Id = 256, Name = "王五", Number = "24320152202356" };
            Student s1 = new Student { Id = 248, Name = "李四", Number = "24320152202345" };
            Student s2 = new Student { Id = 233, Name = "张三", Number = "24320152202333" };
            List<Student> memberList = new List<Student> { s1, s2 };
            List<Topic> topics = new List<Topic> { new Topic { Id = 258, Serial = "B", Name = "数据库设计", Description = "XXXXXXXX", GroupLimit = 5, GroupMemberLimit = 5, GroupLeft = 1 } };
            SeminarGrade sg3 = new SeminarGrade { PresentationGrade = new List<int> { 5 } };
            Group group = new Group { Id = 30, Name = "1-B-1", Leader = leader, Members = memberList, Topics = topics, Report = "/report/30.pdf", Grade = sg3 };
            if (embedTopics == false)
                group.Topics = null;
            if (embedGrade == false)
                group.Grade = null;

            // If group not found
            if (group == null)
                return NotFound();

            // Success
            return Json(group);
        }

        //下面的可以不用写

        //// PUT: /group/{groupId}/add
        //[HttpPut("{groupId}/add")]
        //public IActionResult AddGroupMember(int groupId, [FromBody]dynamic json)
        //{
        //    return Ok();
        //}

        //// PUT: /group/{groupId}/remove
        //[HttpPut("{groupId}/remove")]
        //public IActionResult RemoveGroupMember(int groupId, [FromBody]dynamic json)
        //{
        //    return Ok();
        //}

        // POST: /group/{groupId}/topic
        [HttpPost("{groupId}/topic")]
        public IActionResult PostNewTopic(int groupId, [FromBody]dynamic json)
        {
            //Authentication
            //When user's permission denied
            //if(false)
            //  return Forbid();
            
            // Get information from json
            Student newStudentInClass = new Student { Id = int.Parse(json.Id) };

            // Judge and store class-student information in server

            // If already select another class under the same course
            //  return Conflict(); 

            // Return class id & student id
            //string uri = "/class/" + classId + "/student/" + newStudentInClass.Id;
            //return Created(uri, newStudentInClass);
            return Ok();
        }

        // DELETE: /group/{groupId}/topic/{topicId}
        [HttpPost("{groupId}/topic/{topicId}")]
        public IActionResult DeleteTopic(int groupId, int topicId, [FromBody]dynamic json)
        {
            return Ok();
        }

        // GET: /group/{groupId}/grade
        [HttpGet("{groupId}/grade")]
        public IActionResult GetGroupSeminarGrade(int groupId)
        {
            return Ok();
        }

        // PUT: /group/{groupId}/grade/report
        [HttpGet("{groupId}/grade/report")]
        public IActionResult PutGroupReportGrade(int groupId, [FromBody]dynamic json)
        {
            return Ok();
        }

    }
}
