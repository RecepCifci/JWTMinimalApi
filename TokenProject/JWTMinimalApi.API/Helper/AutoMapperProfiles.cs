namespace JWTMinimalApi.API.Helper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<UserRequestModel, AuthenticateRequest>();
            CreateMap<AuthenticateRequest, UserRequestModel>();

            CreateMap<UserRequestModel, UserResponseModel>();
            CreateMap<UserResponseModel, UserRequestModel>();
        }
    }
}