﻿using Haowen.Application.Caching;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Haowen;

[DependsOn(
    typeof(AbpIdentityApplicationModule),
    typeof(AbpAutoMapperModule),
    typeof(HaowenAppCachingModule)    
    )]
public class HaowenApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        //context.Services.AddTransient<IArticleService,ArticleService>()

        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<HaowenApplicationModule>(validate: true);
            options.AddProfile<HaowenAutoMapperProfile>(validate: true);
        });
    }
}
