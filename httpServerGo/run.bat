@echo off

if not "%GO_INIT%"=="1" (
set GO_INIT=1
set GOPATH=%GOPATH%;%cd%
)

set GOARCH=386
set CGO_ENABLED=1

go run -tags=debug main.go -ip=localhost -port=8060 -https -key=0efce07c
