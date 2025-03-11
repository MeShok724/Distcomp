﻿using DistComp.DTO.RequestDTO;
using DistComp.DTO.ResponseDTO;

namespace DistComp.Services.Interfaces;

public interface INoticeService
{
    Task<IEnumerable<NoticeResponseDTO>> GetNoticesAsync();

    Task<NoticeResponseDTO> GetNoticeByIdAsync(long id);

    Task<NoticeResponseDTO> CreateNoticeAsync(NoticeRequestDTO notice);

    Task<NoticeResponseDTO> UpdateNoticeAsync(NoticeRequestDTO notice);

    Task DeleteNoticeAsync(long id);
}