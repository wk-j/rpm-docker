#!/bin/sh

rpmbuild --bb --target noarch /working/MyWeb.spec --define "_rpmdir /working"