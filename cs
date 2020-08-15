#!/bin/bash
# My first script

bundle exec jekyll build
scp -r _site domta@attu.cs.washington.edu:/cse/web/homes/domta
