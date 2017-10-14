﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace SolidHttp
{
    internal class SolidHttpEvents : ISolidHttpEventInvoker
    {
        public event EventHandler<SolidHttpClientCreatedEventArgs> OnClientCreated;
        public event EventHandler<SolidHttpRequestCreatedEventArgs> OnRequestCreated;
        public event EventHandler<RequestEventArgs> OnRequest;
        public event EventHandler<ResponseEventArgs> OnResponse;        

        public void InvokeOnClientCreated(object invoker, SolidHttpClient client)
        {
            if (OnClientCreated != null)
                OnClientCreated(invoker, new SolidHttpClientCreatedEventArgs { Client = client });
        }

        public void InvokeOnRequest(object invoker, HttpRequestMessage request)
        {
            if (OnRequest != null)
                OnRequest(invoker, new RequestEventArgs { Request = request });
        }

        public void InvokeOnRequestCreated(object invoker, SolidHttpRequest request)
        {
            if (OnRequestCreated != null)
                OnRequestCreated(invoker, new SolidHttpRequestCreatedEventArgs { Request = request });
        }

        public void InvokeOnResponse(object invoker, HttpResponseMessage response)
        {
            if (OnResponse != null)
                OnResponse(invoker, new ResponseEventArgs { Response = response });
        }
    }
}