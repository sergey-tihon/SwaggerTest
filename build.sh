#!/bin/bash

dotnet tool install paket --tool-path .paket

.paket/paket restore

dotnet build SwaggerTest.sln