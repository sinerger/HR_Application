using HR_Application_BLL.Models.Base;
using HR_Application_DB_Logic.Models;
using System;
using System.Collections.Generic;

namespace HR_Application_BLL.Mappers.Base
{
    public class CommentMapper : BaseMapper
    {
        public List<CommentModel> GetModelsFromDTO(List<CommentDTO> commentsDTO)
        {
            if (commentsDTO != null)
            {
                return _mapper.Map<List<CommentModel>>(commentsDTO);
            }

            throw new ArgumentNullException("List of comments is null");
        }

        public CommentModel GetModelFromDTO(CommentDTO commentDTO)
        {
            if (commentDTO != null)
            {
                return _mapper.Map<CommentModel>(commentDTO);
            }

            throw new ArgumentNullException("Comment DTO is null");
        }

        public CommentDTO GetDTOFromModel(CommentModel commentModel)
        {
            if (commentModel != null)
            {
                return _mapper.Map<CommentDTO>(commentModel);
            }

            throw new ArgumentNullException("Comment model is null");
        }
    }
}
