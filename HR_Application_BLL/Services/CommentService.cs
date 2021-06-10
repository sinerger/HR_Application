using HR_Application_BLL.Mappers.Base;
using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Interfaces;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR_Application_BLL.Services
{
   public class CommentService
    {
        private IDBController _dbController;
        private CommentMapper _commentMapper;

        public CommentService(IDBController dbController)
        {
            _dbController = dbController;
            _commentMapper = new CommentMapper();
        }

        public List<CommentModel> GetAll()
        {
            try
            {
                List<CommentDTO> commentsDTO = _dbController.CommentRepository.GetAll();

                return _commentMapper.GetModelsFromDTO(commentsDTO);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public CommentModel GetByID(int id)
        {
            if (id >= 0)
            {
                try
                {
                    CommentDTO commentDTO = _dbController.CommentRepository.GetByID(id);

                    return _commentMapper.GetModelFromDTO(commentDTO);
                }
                catch (Exception e)
                {

                    throw e;
                }
            }

            throw new ArgumentException("Invalid id");
        }
    }
}
