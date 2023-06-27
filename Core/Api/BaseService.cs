﻿namespace ApiTests.Core;

public class BaseService
{
    protected BaseApiClient ApiClient { get; set; }

    public BaseService(BaseApiClient apiClient)
    {
        ApiClient = apiClient;
    }
}