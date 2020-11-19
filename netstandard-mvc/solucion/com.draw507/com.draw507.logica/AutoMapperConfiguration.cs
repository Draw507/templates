//using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.draw507.logica
{
    public class AutoMapperConfiguration
    {
        public static void RegisterMappings()
        {
            //Mapper.Initialize(cfg => {
            //    cfg.CreateMap<app_niif_imported_data, ExportEAD_DTO>()
            //    .ForMember(dto => dto.fecha, map => map.MapFrom(m => m.fecha.ToDateFormat()));

            //    cfg.CreateMap<app_credito_imported_pd, ExportPD_DTO>()
            //    .ForMember(dto => dto.mes, map => map.MapFrom(m => m.mes.ToDateFormat()));

            //    cfg.CreateMap<NIIF_AUD_REGISTROS, ExportAuditoria_DTO>()
            //    .ForMember(dto => dto.fecha, map => map.MapFrom(m => m.fecha.ToDateFormat()));

            //    cfg.CreateMap<app_niif_incumplimientos_lgd, ExportLGD_DTO>()
            //    .ForMember(dto => dto.mes, map => map.MapFrom(m => m.mes.ToDateFormat()))
            //    .ForMember(dto => dto.fecha_default, map => map.MapFrom(m => m.fecha_default.ToDateFormat()))
            //    .ForMember(dto => dto.fecha_recuperacion, map => map.MapFrom(m => m.fecha_recuperacion.ToDateFormat()));

            //    cfg.CreateMap<app_credito_imported_pd, PD_DTO>()
            //    .ForMember(dto => dto.StringMes, map => map.MapFrom(m => m.mes.ToDateFormat()))
            //    .ForMember(dto => dto.tipo, map => map.MapFrom(m => string.Format("{0} - {1}", m.instrumento_tipo_codigo, m.instrumento_tipo_descripcion)))
            //    .ForMember(dto => dto.garantia, map => map.MapFrom(m => string.Format("{0} - {1}", m.garantia_codigo, m.garantia_descripcion)));

            //    cfg.CreateMap<app_niif_incumplimientos_lgd, LGD_DTO>()
            //    .ForMember(dto => dto.StringMes, map => map.MapFrom(m => m.mes.ToDateFormat()))
            //    .ForMember(dto => dto.Stringfecha_default, map => map.MapFrom(m => m.fecha_default.ToDateFormat()))
            //    .ForMember(dto => dto.Stringfecha_recuperacion, map => map.MapFrom(m => m.fecha_recuperacion.ToDateFormat()))
            //    .ForMember(dto => dto.tipo, map => map.MapFrom(m => string.Format("{0} - {1}", m.instrumento_tipo_codigo, m.instrumento_tipo_descripcion)))
            //    .ForMember(dto => dto.garantia, map => map.MapFrom(m => string.Format("{0} - {1}", m.garantia_codigo, m.garantia_descripcion)));

            //    cfg.CreateMap<app_niif_imported_data, EAD_DTO>()
            //    .ForMember(dto => dto.fecha, map => map.MapFrom(m => m.fecha.ToDateFormat()))
            //    .ForMember(dto => dto.tipo, map => map.MapFrom(m => string.Format("{0} - {1}", m.instrumento_tipo_codigo, m.instrumento_tipo_descripcion)))
            //    .ForMember(dto => dto.garantia, map => map.MapFrom(m => string.Format("{0} - {1}", m.garantia_codigo, m.garantia_descripcion)));
            //});
        }
    }
}
