import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'HospitalApp',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44394/',
    redirectUri: baseUrl,
    clientId: 'HospitalApp_App',
    responseType: 'code',
    scope: 'offline_access HospitalApp',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44394',
      rootNamespace: 'HospitalApp',
    },
  },
} as Environment;
