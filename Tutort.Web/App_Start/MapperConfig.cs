using AutoMapper;
using Tutort.SocialNetworks.Instagram.Models;
using Tutort.Web.ViewModels.Social;
using Tutort.Web.ViewModels.Social.Instagram;

namespace Tutort.Web
{
	public class MapperConfig
	{
		public static void RegisterAllMapping()
		{
			RegisterModelMappings();
			RegisterModelViewMappings();
		}

		private static void RegisterModelMappings()
		{
		}

		private static void RegisterModelViewMappings()
		{
			Mapper.Initialize(x => x.CreateMap<Image, ImageViewModel>());
			//.ForMember(mv => mv.Url, m => m.MapFrom(model => model.Url))
			//.ForMember(mv => mv.Height, m => m.MapFrom(model => model.Height))
			//.ForMember(mv => mv.Width, m => m.MapFrom(model => model.Width)));

			Mapper.Initialize(x => x.CreateMap<PostData, InstagramPostViewModel>()
				.ForMember(mv => mv.Url, m => m.MapFrom(model => model.Link))
				.ForMember(mv => mv.Date, m => m.MapFrom(model => model.CreatedTime))
				.ForMember(mv => mv.Description, m => m.MapFrom(model => model.Caption.Text)));
				//.ForMember(mv => mv.Image, m => m.MapFrom(model => Mapper.Map<Image, ImageViewModel>(model.ImageList.Thumbnail))));
		}
	}
}