#!/bin/bash
# Sync local files with server
# Requires server and client to be setup with unison (https://github.com/bcpierce00/unison)
# `server` hostname is from ssh config

unison ~/sync ssh://server/sync
